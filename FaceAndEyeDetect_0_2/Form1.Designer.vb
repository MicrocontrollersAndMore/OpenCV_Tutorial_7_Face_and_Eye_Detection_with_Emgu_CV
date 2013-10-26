<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.ibImage = New Emgu.CV.UI.ImageBox()
		Me.lblHarrFaceFile = New System.Windows.Forms.Label()
		Me.lblHarrEyeFile = New System.Windows.Forms.Label()
		Me.lblImageFile = New System.Windows.Forms.Label()
		Me.lblInstructions = New System.Windows.Forms.Label()
		Me.lblProcessingTime = New System.Windows.Forms.Label()
		Me.txtHaarFaceFile = New System.Windows.Forms.TextBox()
		Me.txtHaarEyeFile = New System.Windows.Forms.TextBox()
		Me.txtImageFile = New System.Windows.Forms.TextBox()
		Me.gbSpeedVsAccuracy = New System.Windows.Forms.GroupBox()
		Me.rdoFastest = New System.Windows.Forms.RadioButton()
		Me.rdoBalanced = New System.Windows.Forms.RadioButton()
		Me.rdoMostAccurate = New System.Windows.Forms.RadioButton()
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
		Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
		Me.ofdHaarFace = New System.Windows.Forms.OpenFileDialog()
		Me.ofdHaarEye = New System.Windows.Forms.OpenFileDialog()
		Me.ofdImage = New System.Windows.Forms.OpenFileDialog()
		CType(Me.ibImage,System.ComponentModel.ISupportInitialize).BeginInit
		Me.gbSpeedVsAccuracy.SuspendLayout
		Me.SuspendLayout
		'
		'ibImage
		'
		Me.ibImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ibImage.Location = New System.Drawing.Point(2, 132)
		Me.ibImage.Name = "ibImage"
		Me.ibImage.Size = New System.Drawing.Size(1206, 448)
		Me.ibImage.TabIndex = 2
		Me.ibImage.TabStop = false
		'
		'lblHarrFaceFile
		'
		Me.lblHarrFaceFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblHarrFaceFile.Location = New System.Drawing.Point(0, 48)
		Me.lblHarrFaceFile.Name = "lblHarrFaceFile"
		Me.lblHarrFaceFile.Size = New System.Drawing.Size(172, 23)
		Me.lblHarrFaceFile.TabIndex = 3
		Me.lblHarrFaceFile.Text = "choose Harr face file:"
		'
		'lblHarrEyeFile
		'
		Me.lblHarrEyeFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblHarrEyeFile.Location = New System.Drawing.Point(0, 76)
		Me.lblHarrEyeFile.Name = "lblHarrEyeFile"
		Me.lblHarrEyeFile.Size = New System.Drawing.Size(172, 23)
		Me.lblHarrEyeFile.TabIndex = 4
		Me.lblHarrEyeFile.Text = "choose Haar eye file:"
		'
		'lblImageFile
		'
		Me.lblImageFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblImageFile.Location = New System.Drawing.Point(0, 104)
		Me.lblImageFile.Name = "lblImageFile"
		Me.lblImageFile.Size = New System.Drawing.Size(172, 23)
		Me.lblImageFile.TabIndex = 5
		Me.lblImageFile.Text = "choose image file:"
		'
		'lblInstructions
		'
		Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblInstructions.Location = New System.Drawing.Point(0, 0)
		Me.lblInstructions.Name = "lblInstructions"
		Me.lblInstructions.Size = New System.Drawing.Size(940, 44)
		Me.lblInstructions.TabIndex = 6
		Me.lblInstructions.Text = "Instructions: click on Haar face and eye text boxes to choose Haar face and eye ."& _ 
    "xml file locations (if different than defaults),"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"then click on image file text "& _ 
    "box to load image:"
		'
		'lblProcessingTime
		'
		Me.lblProcessingTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblProcessingTime.Location = New System.Drawing.Point(628, 20)
		Me.lblProcessingTime.Name = "lblProcessingTime"
		Me.lblProcessingTime.Size = New System.Drawing.Size(348, 23)
		Me.lblProcessingTime.TabIndex = 7
		Me.lblProcessingTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'txtHaarFaceFile
		'
		Me.txtHaarFaceFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtHaarFaceFile.Location = New System.Drawing.Point(176, 44)
		Me.txtHaarFaceFile.Name = "txtHaarFaceFile"
		Me.txtHaarFaceFile.Size = New System.Drawing.Size(800, 27)
		Me.txtHaarFaceFile.TabIndex = 8
		Me.txtHaarFaceFile.TabStop = false
		Me.txtHaarFaceFile.Text = "C:\Emgu\emgucv-windows-x86 2.4.0.1717\opencv\data\haarcascades\haarcascade_fronta"& _ 
    "lface_default.xml"
		'
		'txtHaarEyeFile
		'
		Me.txtHaarEyeFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtHaarEyeFile.Location = New System.Drawing.Point(176, 72)
		Me.txtHaarEyeFile.Name = "txtHaarEyeFile"
		Me.txtHaarEyeFile.Size = New System.Drawing.Size(800, 27)
		Me.txtHaarEyeFile.TabIndex = 9
		Me.txtHaarEyeFile.TabStop = false
		Me.txtHaarEyeFile.Text = "C:\Emgu\emgucv-windows-x86 2.4.0.1717\opencv\data\haarcascades\haarcascade_eye.xm"& _ 
    "l"
		'
		'txtImageFile
		'
		Me.txtImageFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtImageFile.Location = New System.Drawing.Point(176, 100)
		Me.txtImageFile.Name = "txtImageFile"
		Me.txtImageFile.Size = New System.Drawing.Size(800, 27)
		Me.txtImageFile.TabIndex = 10
		Me.txtImageFile.TabStop = false
		'
		'gbSpeedVsAccuracy
		'
		Me.gbSpeedVsAccuracy.Controls.Add(Me.rdoMostAccurate)
		Me.gbSpeedVsAccuracy.Controls.Add(Me.rdoBalanced)
		Me.gbSpeedVsAccuracy.Controls.Add(Me.rdoFastest)
		Me.gbSpeedVsAccuracy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gbSpeedVsAccuracy.Location = New System.Drawing.Point(992, 8)
		Me.gbSpeedVsAccuracy.Name = "gbSpeedVsAccuracy"
		Me.gbSpeedVsAccuracy.Size = New System.Drawing.Size(212, 112)
		Me.gbSpeedVsAccuracy.TabIndex = 11
		Me.gbSpeedVsAccuracy.TabStop = false
		Me.gbSpeedVsAccuracy.Text = "speed vs accuracy"
		'
		'rdoFastest
		'
		Me.rdoFastest.AutoSize = true
		Me.rdoFastest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.rdoFastest.Location = New System.Drawing.Point(8, 24)
		Me.rdoFastest.Name = "rdoFastest"
		Me.rdoFastest.Size = New System.Drawing.Size(200, 24)
		Me.rdoFastest.TabIndex = 0
		Me.rdoFastest.Text = "fastest, lease accurate"
		Me.rdoFastest.UseVisualStyleBackColor = true
		'
		'rdoBalanced
		'
		Me.rdoBalanced.AutoSize = true
		Me.rdoBalanced.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.rdoBalanced.Location = New System.Drawing.Point(8, 52)
		Me.rdoBalanced.Name = "rdoBalanced"
		Me.rdoBalanced.Size = New System.Drawing.Size(97, 24)
		Me.rdoBalanced.TabIndex = 1
		Me.rdoBalanced.Text = "balanced"
		Me.rdoBalanced.UseVisualStyleBackColor = true
		'
		'rdoMostAccurate
		'
		Me.rdoMostAccurate.AutoSize = true
		Me.rdoMostAccurate.Checked = true
		Me.rdoMostAccurate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.rdoMostAccurate.Location = New System.Drawing.Point(8, 80)
		Me.rdoMostAccurate.Name = "rdoMostAccurate"
		Me.rdoMostAccurate.Size = New System.Drawing.Size(203, 24)
		Me.rdoMostAccurate.TabIndex = 2
		Me.rdoMostAccurate.TabStop = true
		Me.rdoMostAccurate.Text = "slowest, most accurate"
		Me.rdoMostAccurate.UseVisualStyleBackColor = true
		'
		'ShapeContainer1
		'
		Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
		Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
		Me.ShapeContainer1.Name = "ShapeContainer1"
		Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
		Me.ShapeContainer1.Size = New System.Drawing.Size(1211, 584)
		Me.ShapeContainer1.TabIndex = 12
		Me.ShapeContainer1.TabStop = false
		'
		'LineShape1
		'
		Me.LineShape1.Name = "LineShape1"
		Me.LineShape1.X1 = 984
		Me.LineShape1.X2 = 984
		Me.LineShape1.Y1 = 0
		Me.LineShape1.Y2 = 131
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1211, 584)
		Me.Controls.Add(Me.gbSpeedVsAccuracy)
		Me.Controls.Add(Me.lblProcessingTime)
		Me.Controls.Add(Me.txtImageFile)
		Me.Controls.Add(Me.txtHaarEyeFile)
		Me.Controls.Add(Me.txtHaarFaceFile)
		Me.Controls.Add(Me.lblInstructions)
		Me.Controls.Add(Me.lblImageFile)
		Me.Controls.Add(Me.lblHarrEyeFile)
		Me.Controls.Add(Me.lblHarrFaceFile)
		Me.Controls.Add(Me.ibImage)
		Me.Controls.Add(Me.ShapeContainer1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		CType(Me.ibImage,System.ComponentModel.ISupportInitialize).EndInit
		Me.gbSpeedVsAccuracy.ResumeLayout(false)
		Me.gbSpeedVsAccuracy.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub
    Friend WithEvents ibImage As Emgu.CV.UI.ImageBox
    Friend WithEvents lblHarrFaceFile As System.Windows.Forms.Label
    Friend WithEvents lblHarrEyeFile As System.Windows.Forms.Label
    Friend WithEvents lblImageFile As System.Windows.Forms.Label
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents lblProcessingTime As System.Windows.Forms.Label
    Friend WithEvents txtHaarFaceFile As System.Windows.Forms.TextBox
    Friend WithEvents txtHaarEyeFile As System.Windows.Forms.TextBox
    Friend WithEvents txtImageFile As System.Windows.Forms.TextBox
    Friend WithEvents gbSpeedVsAccuracy As System.Windows.Forms.GroupBox
    Friend WithEvents rdoMostAccurate As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBalanced As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFastest As System.Windows.Forms.RadioButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ofdHaarFace As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ofdHaarEye As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ofdImage As System.Windows.Forms.OpenFileDialog

End Class
