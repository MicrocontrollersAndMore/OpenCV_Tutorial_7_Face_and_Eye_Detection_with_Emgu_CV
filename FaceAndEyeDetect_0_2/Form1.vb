Option Strict

Imports Emgu.CV
Imports Emgu.CV.CvEnum
Imports Emgu.CV.Structure
Imports Emgu.CV.UI

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Class Form1

' member variables ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Dim blnFirstTimeInResizeEvent As Boolean = True
Dim intOrigFormWidth As Integer = 0
Dim intOrigFormHeight As Integer = 0
Dim intOrigImageBoxWidth As Integer = 0
Dim intOrigImageBoxHeight As Integer = 0

Dim imgOriginal As Image(Of Bgr, Byte)
Dim imgGray As Image(Of Gray, Byte)
Dim imgBlank As Image(Of Bgr, Byte)

Dim acFaces As MCvAvgComp()
Dim acEyes As MCvAvgComp()

Dim hcFaceDetector As HaarCascade
Dim hcEyeDetector As HaarCascade

Dim swStopWatch As New Stopwatch()
Dim tsTimeSpan As TimeSpan
Dim strElapsedTime As String = ""

' constructor '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Sub New()
	InitializeComponent()				'always call this in a visual basic form constructor, necessary to init form

	intOrigFormWidth = Me.Width
	intOrigFormHeight = Me.Height
	intOrigImageBoxWidth = ibImage.Width
	intOrigImageBoxHeight = ibImage.Height
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub Form1_Resize( sender As System.Object,  e As System.EventArgs) Handles MyBase.Resize
	'This If Else statement is necessary to throw out the first time the Form1_Resize event is called.
	'For some reason, in VB.NET the Resize event is called once before the constructor, then the constructor is called,
	'then the Resize event is called each time the form is resized.  The first time the Resize event is called
	'(i.e. before the constructor is called) the coordinates of the components on the form all read zero,
	'therefore we have to throw out this first call, then the constructor will run and get the correct initial
	'component location data, then every time after that we can let the Resize event run as expected
	If(blnFirstTimeInResizeEvent = True) Then
		blnFirstTimeInResizeEvent = False
	Else
		ibImage.Width = Me.Width - (intOrigFormWidth - intOrigImageBoxWidth)
		ibImage.Height = Me.Height - (intOrigFormHeight - intOrigImageBoxHeight)
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub txtHaarFaceFile_Click( sender As System.Object,  e As System.EventArgs) Handles txtHaarFaceFile.Click
	Dim drHaarFaceFile As DialogResult

	drHaarFaceFile = ofdHaarFace.ShowDialog()
	txtHaarFaceFile.Text = ofdHaarFace.FileName

	If(drHaarFaceFile = Windows.Forms.DialogResult.OK And ofdHaarFace.FileName <> "") Then
		txtHaarFaceFile.Text = ofdHaarFace.FileName
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub txtHaarEyeFile_Click( sender As System.Object,  e As System.EventArgs) Handles txtHaarEyeFile.Click
	Dim drHaarEyeFile As DialogResult

	drHaarEyeFile = ofdHaarEye.ShowDialog()
	txtHaarEyeFile.Text = ofdHaarEye.FileName

	If(drHaarEyeFile = Windows.Forms.DialogResult.OK And ofdHaarEye.FileName <> "") Then
		txtHaarEyeFile.Text = ofdHaarEye.FileName
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub txtImageFile_Click( sender As System.Object,  e As System.EventArgs) Handles txtImageFile.Click
	Dim drImageFile As DialogResult

	drImageFile = ofdImage.ShowDialog()
	txtImageFile.Text = ofdImage.FileName

	If(drImageFile = Windows.Forms.DialogResult.OK And ofdImage.FileName <> "") Then
		LoadAndProcessImage()
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Sub LoadAndProcessImage()
	imgOriginal = New Image(Of Bgr, Byte)(txtImageFile.Text)
	imgGray = imgOriginal.Convert(Of Gray, Byte)()

	hcFaceDetector = New HaarCascade(txtHaarFaceFile.Text)
	hcEyeDetector = New HaarCascade(txtHaarEyeFile.Text)

	lblProcessingTime.Text = "processing . . .               "
	ibImage.Image = imgBlank
	Application.DoEvents()
	swStopWatch.Start()

	If(rdoFastest.Checked = True) Then
																	 'the image where the objects are to be detected from
																						'factor by which the window is scaled between subsequent scans
																								 'min number of neighbor rectangles
																										'mode of operation, currently DO_CANNY_PRUNING is the only option
																																													'min window size, use Size.Empty for default
																																																			'max window size, use Size.Empty for default
		acFaces = hcFaceDetector.Detect(imgGray, 1.2, 2, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, Size.Empty, Size.Empty)
		acEyes = hcEyeDetector.Detect(imgGray, 1.2, 2, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, Size.Empty, Size.Empty)
	ElseIf(rdoBalanced.Checked = True) Then
		acFaces = hcFaceDetector.Detect(imgGray, 1.1, 3, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, Size.Empty, Size.Empty)
		acEyes = hcEyeDetector.Detect(imgGray, 1.1, 3, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, Size.Empty, Size.Empty)
	ElseIf(rdoMostAccurate.Checked = True) Then
		acFaces = hcFaceDetector.Detect(imgGray, 1.1, 10, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, Size.Empty, Size.Empty)
		acEyes = hcEyeDetector.Detect(imgGray, 1.1, 25, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, Size.Empty, Size.Empty)
	Else
		'should never get here
	End If

	swStopWatch.Stop()
	tsTimeSpan = swStopWatch.Elapsed
	strElapsedTime = String.Format("processing time = {0:00}.{1:00} sec", tsTimeSpan.Seconds, tsTimeSpan.Milliseconds / 10)
	lblProcessingTime.Text = strElapsedTime
	swStopWatch.Reset()

	For Each acFace As MCvAvgComp In acFaces
		imgOriginal.Draw(acFace.rect, New Bgr(Color.Red), 2)
	Next
	
	For Each acEye As MCvAvgComp In acEyes
		imgOriginal.Draw(acEye.rect, New Bgr(Color.Blue), 2)
	Next
	
	ibImage.Image = imgOriginal
End Sub

End Class
