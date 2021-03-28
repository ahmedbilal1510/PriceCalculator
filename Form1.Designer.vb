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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtPrdctName = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblPrdctName = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalAns = New System.Windows.Forms.Label()
        Me.lblTaxAns = New System.Windows.Forms.Label()
        Me.lblSubTotalAns = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblSubTtl = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtPrdctName)
        Me.GroupBox1.Controls.Add(Me.lblQuantity)
        Me.GroupBox1.Controls.Add(Me.lblPrice)
        Me.GroupBox1.Controls.Add(Me.lblPrdctName)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 113)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(118, 73)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(88, 20)
        Me.txtQuantity.TabIndex = 5
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(118, 49)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(88, 20)
        Me.txtPrice.TabIndex = 4
        '
        'txtPrdctName
        '
        Me.txtPrdctName.Location = New System.Drawing.Point(118, 23)
        Me.txtPrdctName.Name = "txtPrdctName"
        Me.txtPrdctName.Size = New System.Drawing.Size(88, 20)
        Me.txtPrdctName.TabIndex = 3
        '
        'lblQuantity
        '
        Me.lblQuantity.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblQuantity.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(24, 75)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(88, 17)
        Me.lblQuantity.TabIndex = 2
        Me.lblQuantity.Text = "Quantity:"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblPrice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(24, 49)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(88, 20)
        Me.lblPrice.TabIndex = 1
        Me.lblPrice.Text = "Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrdctName
        '
        Me.lblPrdctName.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblPrdctName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrdctName.Location = New System.Drawing.Point(24, 23)
        Me.lblPrdctName.Name = "lblPrdctName"
        Me.lblPrdctName.Size = New System.Drawing.Size(88, 20)
        Me.lblPrdctName.TabIndex = 0
        Me.lblPrdctName.Text = "Product Name:"
        Me.lblPrdctName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalAns)
        Me.GroupBox2.Controls.Add(Me.lblTaxAns)
        Me.GroupBox2.Controls.Add(Me.lblSubTotalAns)
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.lblTax)
        Me.GroupBox2.Controls.Add(Me.lblSubTotal)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(40, 194)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(228, 104)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output:"
        '
        'lblTotalAns
        '
        Me.lblTotalAns.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalAns.Location = New System.Drawing.Point(118, 79)
        Me.lblTotalAns.Name = "lblTotalAns"
        Me.lblTotalAns.Size = New System.Drawing.Size(104, 14)
        Me.lblTotalAns.TabIndex = 5
        Me.lblTotalAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTaxAns
        '
        Me.lblTaxAns.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTaxAns.Location = New System.Drawing.Point(118, 50)
        Me.lblTaxAns.Name = "lblTaxAns"
        Me.lblTaxAns.Size = New System.Drawing.Size(104, 14)
        Me.lblTaxAns.TabIndex = 4
        Me.lblTaxAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubTotalAns
        '
        Me.lblSubTotalAns.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSubTotalAns.Location = New System.Drawing.Point(118, 24)
        Me.lblSubTotalAns.Name = "lblSubTotalAns"
        Me.lblSubTotalAns.Size = New System.Drawing.Size(104, 13)
        Me.lblSubTotalAns.TabIndex = 3
        Me.lblSubTotalAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblTotal.Location = New System.Drawing.Point(24, 79)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(83, 14)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Total:"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblTax.Location = New System.Drawing.Point(24, 50)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(83, 14)
        Me.lblTax.TabIndex = 1
        Me.lblTax.Text = "Tax:"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblSubTotal.Location = New System.Drawing.Point(24, 24)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(83, 17)
        Me.lblSubTotal.TabIndex = 0
        Me.lblSubTotal.Text = "SubTotal:"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubTtl
        '
        Me.lblSubTtl.AutoSize = True
        Me.lblSubTtl.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTtl.Location = New System.Drawing.Point(46, 9)
        Me.lblSubTtl.Name = "lblSubTtl"
        Me.lblSubTtl.Size = New System.Drawing.Size(222, 14)
        Me.lblSubTtl.TabIndex = 2
        Me.lblSubTtl.Text = "Input Product Name, Quantity, and Price"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(71, 167)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(59, 21)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(192, 170)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(52, 20)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 328)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblSubTtl)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Price Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtPrdctName As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblPrdctName As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTotalAns As Label
    Friend WithEvents lblTaxAns As Label
    Friend WithEvents lblSubTotalAns As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblSubTtl As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
End Class
