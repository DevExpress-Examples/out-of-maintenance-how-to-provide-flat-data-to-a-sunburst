Namespace SunburstFlatDataAdapterSample
    Partial Public Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.sunburstControl = New DevExpress.XtraTreeMap.SunburstControl()
            CType(Me.sunburstControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sunburstControl
            ' 
            Me.sunburstControl.BackColor = System.Drawing.Color.White
            Me.sunburstControl.BorderOptions.Color = System.Drawing.Color.FromArgb((CInt((CByte(157)))), (CInt((CByte(160)))), (CInt((CByte(170)))))
            Me.sunburstControl.BorderOptions.Visible = False
            Me.sunburstControl.CenterLabel.BackgroundColor = System.Drawing.Color.White
            Me.sunburstControl.CenterLabel.TextFont = New System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold)
            Me.sunburstControl.CenterLabel.TextPattern = "Products Export"
            Me.sunburstControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sunburstControl.Location = New System.Drawing.Point(0, 0)
            Me.sunburstControl.Name = "sunburstControl"
            Me.sunburstControl.Padding = New System.Windows.Forms.Padding(10)
            Me.sunburstControl.Size = New System.Drawing.Size(486, 450)
            Me.sunburstControl.StartAngle = 0R
            Me.sunburstControl.TabIndex = 0
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(486, 450)
            Me.Controls.Add(Me.sunburstControl)
            Me.Name = "MainForm"
            Me.Text = "MainForm"
            CType(Me.sunburstControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private sunburstControl As DevExpress.XtraTreeMap.SunburstControl
    End Class
End Namespace

