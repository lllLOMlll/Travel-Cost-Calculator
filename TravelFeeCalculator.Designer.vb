<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TravelFeeCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(TravelFeeCalculator))
        label_title = New Label()
        label_number_of_kilometers = New Label()
        textBox_num_of_km = New TextBox()
        label_gas_consumption = New Label()
        textBox_gas_consumption = New TextBox()
        label_gas_price = New Label()
        textBox_gas_price = New TextBox()
        label_number_of_passengers = New Label()
        textBox_number_of_passengers = New TextBox()
        label_driver_included = New Label()
        radioBtn_yes = New RadioButton()
        radioBtn_no = New RadioButton()
        btn_calculate_fee = New Button()
        btn_reset = New Button()
        label_fee_per_person_tittle = New Label()
        label_display_fee = New Label()
        SuspendLayout()
        ' 
        ' label_title
        ' 
        label_title.AutoSize = True
        label_title.Font = New Font("Modern No. 20", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point)
        label_title.Location = New Point(38, 18)
        label_title.Name = "label_title"
        label_title.Size = New Size(460, 50)
        label_title.TabIndex = 0
        label_title.Text = "Travel Fee Calculator"
        ' 
        ' label_number_of_kilometers
        ' 
        label_number_of_kilometers.AutoSize = True
        label_number_of_kilometers.BackColor = Color.Black
        label_number_of_kilometers.FlatStyle = FlatStyle.Flat
        label_number_of_kilometers.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        label_number_of_kilometers.ForeColor = Color.White
        label_number_of_kilometers.Location = New Point(38, 113)
        label_number_of_kilometers.Name = "label_number_of_kilometers"
        label_number_of_kilometers.Size = New Size(215, 26)
        label_number_of_kilometers.TabIndex = 1
        label_number_of_kilometers.Text = "Number of Kilometers"
        ' 
        ' textBox_num_of_km
        ' 
        textBox_num_of_km.BorderStyle = BorderStyle.FixedSingle
        textBox_num_of_km.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        textBox_num_of_km.Location = New Point(322, 106)
        textBox_num_of_km.Name = "textBox_num_of_km"
        textBox_num_of_km.Size = New Size(100, 33)
        textBox_num_of_km.TabIndex = 2
        ' 
        ' label_gas_consumption
        ' 
        label_gas_consumption.AutoSize = True
        label_gas_consumption.BackColor = Color.Black
        label_gas_consumption.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        label_gas_consumption.ForeColor = Color.White
        label_gas_consumption.Location = New Point(38, 168)
        label_gas_consumption.Name = "label_gas_consumption"
        label_gas_consumption.Size = New Size(269, 26)
        label_gas_consumption.TabIndex = 3
        label_gas_consumption.Text = "Gas Consumption (L/100km)"
        ' 
        ' textBox_gas_consumption
        ' 
        textBox_gas_consumption.BorderStyle = BorderStyle.FixedSingle
        textBox_gas_consumption.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        textBox_gas_consumption.Location = New Point(322, 161)
        textBox_gas_consumption.Name = "textBox_gas_consumption"
        textBox_gas_consumption.Size = New Size(100, 33)
        textBox_gas_consumption.TabIndex = 4
        ' 
        ' label_gas_price
        ' 
        label_gas_price.AutoSize = True
        label_gas_price.BackColor = Color.Black
        label_gas_price.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        label_gas_price.ForeColor = Color.White
        label_gas_price.Location = New Point(38, 224)
        label_gas_price.Name = "label_gas_price"
        label_gas_price.Size = New Size(139, 26)
        label_gas_price.TabIndex = 5
        label_gas_price.Text = "Gas Price ($/L)"
        ' 
        ' textBox_gas_price
        ' 
        textBox_gas_price.BorderStyle = BorderStyle.FixedSingle
        textBox_gas_price.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        textBox_gas_price.Location = New Point(322, 217)
        textBox_gas_price.Name = "textBox_gas_price"
        textBox_gas_price.Size = New Size(100, 33)
        textBox_gas_price.TabIndex = 6
        ' 
        ' label_number_of_passengers
        ' 
        label_number_of_passengers.AutoSize = True
        label_number_of_passengers.BackColor = Color.Black
        label_number_of_passengers.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        label_number_of_passengers.ForeColor = Color.White
        label_number_of_passengers.Location = New Point(477, 109)
        label_number_of_passengers.Name = "label_number_of_passengers"
        label_number_of_passengers.Size = New Size(212, 26)
        label_number_of_passengers.TabIndex = 7
        label_number_of_passengers.Text = "Number of Passengers"
        ' 
        ' textBox_number_of_passengers
        ' 
        textBox_number_of_passengers.BorderStyle = BorderStyle.FixedSingle
        textBox_number_of_passengers.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        textBox_number_of_passengers.Location = New Point(706, 102)
        textBox_number_of_passengers.Name = "textBox_number_of_passengers"
        textBox_number_of_passengers.Size = New Size(100, 33)
        textBox_number_of_passengers.TabIndex = 8
        ' 
        ' label_driver_included
        ' 
        label_driver_included.AutoSize = True
        label_driver_included.BackColor = Color.Black
        label_driver_included.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        label_driver_included.ForeColor = Color.White
        label_driver_included.Location = New Point(477, 168)
        label_driver_included.Name = "label_driver_included"
        label_driver_included.Size = New Size(163, 26)
        label_driver_included.TabIndex = 9
        label_driver_included.Text = "Driver Included?"
        ' 
        ' radioBtn_yes
        ' 
        radioBtn_yes.AutoSize = True
        radioBtn_yes.BackColor = Color.Black
        radioBtn_yes.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        radioBtn_yes.ForeColor = Color.Transparent
        radioBtn_yes.Location = New Point(484, 210)
        radioBtn_yes.Name = "radioBtn_yes"
        radioBtn_yes.Padding = New Padding(5, 0, 0, 0)
        radioBtn_yes.Size = New Size(64, 30)
        radioBtn_yes.TabIndex = 10
        radioBtn_yes.TabStop = True
        radioBtn_yes.Text = "Yes"
        radioBtn_yes.UseVisualStyleBackColor = False
        ' 
        ' radioBtn_no
        ' 
        radioBtn_no.AutoSize = True
        radioBtn_no.BackColor = Color.Black
        radioBtn_no.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        radioBtn_no.ForeColor = Color.Transparent
        radioBtn_no.Location = New Point(581, 210)
        radioBtn_no.Name = "radioBtn_no"
        radioBtn_no.Padding = New Padding(5, 0, 0, 0)
        radioBtn_no.Size = New Size(61, 30)
        radioBtn_no.TabIndex = 11
        radioBtn_no.TabStop = True
        radioBtn_no.Text = "No"
        radioBtn_no.UseVisualStyleBackColor = False
        ' 
        ' btn_calculate_fee
        ' 
        btn_calculate_fee.BackColor = Color.Black
        btn_calculate_fee.Font = New Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btn_calculate_fee.ForeColor = Color.White
        btn_calculate_fee.Location = New Point(38, 288)
        btn_calculate_fee.Name = "btn_calculate_fee"
        btn_calculate_fee.Size = New Size(406, 60)
        btn_calculate_fee.TabIndex = 12
        btn_calculate_fee.Text = "Calculate Fee"
        btn_calculate_fee.UseVisualStyleBackColor = False
        ' 
        ' btn_reset
        ' 
        btn_reset.BackColor = Color.Black
        btn_reset.Font = New Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btn_reset.ForeColor = Color.White
        btn_reset.Location = New Point(38, 363)
        btn_reset.Name = "btn_reset"
        btn_reset.Size = New Size(406, 60)
        btn_reset.TabIndex = 13
        btn_reset.Text = "Reset"
        btn_reset.UseVisualStyleBackColor = False
        ' 
        ' label_fee_per_person_tittle
        ' 
        label_fee_per_person_tittle.AutoSize = True
        label_fee_per_person_tittle.BackColor = Color.Black
        label_fee_per_person_tittle.Font = New Font("Palatino Linotype", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        label_fee_per_person_tittle.ForeColor = Color.White
        label_fee_per_person_tittle.Location = New Point(484, 282)
        label_fee_per_person_tittle.Name = "label_fee_per_person_tittle"
        label_fee_per_person_tittle.Size = New Size(216, 37)
        label_fee_per_person_tittle.TabIndex = 14
        label_fee_per_person_tittle.Text = "Fee per person :"
        ' 
        ' label_display_fee
        ' 
        label_display_fee.AutoSize = True
        label_display_fee.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        label_display_fee.Font = New Font("Palatino Linotype", 36F, FontStyle.Bold, GraphicsUnit.Point)
        label_display_fee.ForeColor = SystemColors.ActiveCaptionText
        label_display_fee.Location = New Point(484, 332)
        label_display_fee.Name = "label_display_fee"
        label_display_fee.Size = New Size(0, 65)
        label_display_fee.TabIndex = 17
        ' 
        ' TravelFeeCalculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(942, 450)
        Controls.Add(label_display_fee)
        Controls.Add(label_fee_per_person_tittle)
        Controls.Add(btn_reset)
        Controls.Add(btn_calculate_fee)
        Controls.Add(radioBtn_no)
        Controls.Add(radioBtn_yes)
        Controls.Add(label_driver_included)
        Controls.Add(textBox_number_of_passengers)
        Controls.Add(label_number_of_passengers)
        Controls.Add(textBox_gas_price)
        Controls.Add(label_gas_price)
        Controls.Add(textBox_gas_consumption)
        Controls.Add(label_gas_consumption)
        Controls.Add(textBox_num_of_km)
        Controls.Add(label_number_of_kilometers)
        Controls.Add(label_title)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "TravelFeeCalculator"
        Text = "TravelFeeCalculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label_title As Label
    Friend WithEvents label_number_of_kilometers As Label
    Friend WithEvents textBox_num_of_km As TextBox
    Friend WithEvents label_gas_consumption As Label
    Friend WithEvents textBox_gas_consumption As TextBox
    Friend WithEvents label_gas_price As Label
    Friend WithEvents textBox_gas_price As TextBox
    Friend WithEvents label_number_of_passengers As Label
    Friend WithEvents textBox_number_of_passengers As TextBox
    Friend WithEvents label_driver_included As Label
    Friend WithEvents radioBtn_yes As RadioButton
    Friend WithEvents radioBtn_no As RadioButton
    Friend WithEvents btn_calculate_fee As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents label_fee_per_person_tittle As Label
    Friend WithEvents label_display_fee As Label
End Class
