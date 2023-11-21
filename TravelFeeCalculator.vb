Imports System.Reflection.Emit
Imports System.Security.Cryptography.X509Certificates
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml.Schema

Public Class TravelFeeCalculator

    'PUBLIC VARIABLES
    'Input box variables
    Public numOfKm, gasConsumption, gasPrice, numOfPassengers As String

    'Converted strings
    Public numOfPassengersInt As Integer
    Public gasPriceDouble As Double
    Public numOfKmInteger As Integer
    Public gasConsumptionDouble As Double
    Public feePerPerson As Double

    Public driverIncluded, driverNotIncluded As Integer
    Public totalPersons = 0

    Private Sub btn_calculate_fee_Click(sender As Object, e As EventArgs) Handles btn_calculate_fee.Click
        'Initialize isFormValid
        Dim isFormValid As Boolean = True

        'Initialize variables

        'Set values for my variables
        numOfKm = textBox_num_of_km.Text
        gasConsumption = textBox_gas_consumption.Text
        gasPrice = textBox_gas_price.Text
        numOfPassengers = textBox_number_of_passengers.Text

        'Initialize variables (driver included or not)




        'Num of Km
        If String.IsNullOrEmpty(numOfKm) Then
            MsgBox("Number of kilometers cannot be empty", MsgBoxStyle.Exclamation, "Input")
            isFormValid = False
        Else
            If Integer.TryParse(numOfKm, numOfKmInteger) Then
                If numOfKmInteger < 1 OrElse numOfKmInteger > 10000 Then
                    MsgBox("Number of kilometers must be between 1 and 10 000", MsgBoxStyle.Exclamation, "Input")
                    isFormValid = False
                End If
            Else
                MsgBox("Please enter a valid number of kilometers", MsgBoxStyle.Exclamation, "Input")
                isFormValid = False
            End If
        End If

        'Gas Consumption (between 1 and 60)
        If String.IsNullOrEmpty(gasConsumption) Then
            MsgBox("Gas consumption cannot be empty", MsgBoxStyle.Exclamation, "Input")
            isFormValid = False
        Else
            If Double.TryParse(gasConsumption, gasConsumptionDouble) Then
                If gasConsumptionDouble < 1 OrElse gasConsumptionDouble > 60 Then
                    MsgBox("Gas consumption must be between 1 and 60", MsgBoxStyle.Exclamation, "Input")
                    isFormValid = False
                End If
            Else
                MsgBox("Please enter a valid number gas consumption", MsgBoxStyle.Exclamation, "Input")
            End If
        End If

        'Gas Price (Between 0.5 and 3)
        If String.IsNullOrEmpty(gasPrice) Then
            MsgBox("Gas price cannot be empty", MsgBoxStyle.Exclamation, "Input")
            isFormValid = False
        Else
            If Double.TryParse(gasPrice, gasPriceDouble) Then
                If gasPriceDouble < 0.5 OrElse gasPriceDouble > 3 Then
                    MsgBox("Gas price must be between 0.50$ ans 4.00$", MsgBoxStyle.Exclamation, "Input")
                    isFormValid = False
                End If
            Else
                MsgBox("Please enter a valid gas price", MsgBoxStyle.Exclamation, "Input")
            End If
        End If

        'Number of Passengers
        If String.IsNullOrEmpty(numOfPassengers) Then
            MsgBox("Number of passengers cannot be empty", MsgBoxStyle.Exclamation, "Input")
            isFormValid = False
        Else
            If Integer.TryParse(numOfPassengers, numOfPassengersInt) Then
                If numOfPassengersInt < 1 OrElse numOfPassengersInt > 10 Then
                    MsgBox("Number of passengers must be between 1 and 10", MsgBoxStyle.Exclamation, "Input")
                    isFormValid = False
                End If
            Else
                MsgBox("Please enter a valid number of passengers", MsgBoxStyle.Exclamation, "Input")
                isFormValid = False
            End If
        End If


        'Select Include/Not Include drive
        If radioBtn_yes.Checked = False And radioBtn_no.Checked = False Then
            MsgBox("Is the drive included? Please select Yes or No", MsgBoxStyle.Exclamation, "Input")
            isFormValid = False
        Else
            If radioBtn_yes.Checked = True Then
                totalPersons = numOfPassengersInt + 0
            Else
                totalPersons = numOfPassengersInt + 1
            End If
        End If

        'CALCULATE AND DISPLAY
        If isFormValid Then
            feePerPerson = getFeePerPerson(numOfKmInteger, gasConsumptionDouble, gasPriceDouble, totalPersons)
            'F2 = Format 2 decimals
            label_display_fee.Text = feePerPerson.ToString("F2") & "$"
        End If

    End Sub
    'FUNCTIONS
    Public Function getFeePerPerson(ByRef kmToTravel As Double, ByRef consumption As Double, ByRef gasPrice As Double, ByRef numberOfPassengers As Integer) As Double
        ' Calculate the total cost of gas for the trip
        Dim totalGasCost As Double = kmToTravel * (consumption / 100.0) * gasPrice

        ' Calculate the fee per person
        Dim feePerPerson As Double

        feePerPerson = totalGasCost / numberOfPassengers

        ' Return the fee per person
        Return feePerPerson
    End Function


    'SUBS
    'Reset the input boxes
    Sub resetInputBoxes()
        textBox_num_of_km.Text = ""
        textBox_gas_consumption.Text = ""
        textBox_gas_price.Text = ""
        textBox_number_of_passengers.Text = ""
        label_display_fee.Text = ""
        radioBtn_yes.Checked = False
        radioBtn_no.Checked = False
    End Sub


    'Gas consumption (2 digits, 2 decimals)
    Private Sub textBox_gas_consumption_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox_gas_consumption.KeyPress
        ' Allow numbers, the backspace key, and the decimal point
        ' IsControl checks for control characters like backspace
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True ' Reject the character
        End If

        ' Only allow one decimal point
        If e.KeyChar = "."c AndAlso textBox_gas_consumption.Text.IndexOf("."c) > -1 Then
            e.Handled = True ' Reject the character
        End If

        ' Check if the text already has a decimal point and two numbers after it
        'Splitting the number in 2 arrays (after the ".")
        ' "."c means I am refering to the character for the period or decimal
        If textBox_gas_consumption.Text.Contains(".") AndAlso textBox_gas_consumption.Text.Split("."c)(1).Length >= 2 AndAlso Char.IsDigit(e.KeyChar) AndAlso textBox_gas_consumption.SelectionStart > textBox_gas_consumption.Text.IndexOf("."c) Then
            e.Handled = True ' Reject the character
        End If

        ' Check if the text is at the maximum length before the decimal
        If Not textBox_gas_consumption.Text.Contains(".") AndAlso textBox_gas_consumption.Text.Length >= 2 AndAlso Char.IsDigit(e.KeyChar) Then
            If textBox_gas_consumption.SelectionStart <= 1 Then
                ' Allow typing in the first two positions
                e.Handled = False
            Else
                ' If the cursor is beyond the first two digits, reject the character
                e.Handled = True
            End If
        End If
    End Sub

    'Gas price (1 digit, 2 decimals)
    Private Sub textBox_gas_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox_gas_price.KeyPress
        ' Allow numbers, the backspace key, and the decimal point
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True ' Reject the character
        End If

        ' Only allow one decimal point
        If e.KeyChar = "."c AndAlso textBox_gas_price.Text.IndexOf("."c) > -1 Then
            e.Handled = True ' Reject the character
        End If

        ' Check if the text already has a decimal point and two numbers after it
        If textBox_gas_price.Text.Contains(".") AndAlso textBox_gas_price.Text.Split("."c)(1).Length >= 2 AndAlso Char.IsDigit(e.KeyChar) AndAlso textBox_gas_price.SelectionStart > textBox_gas_price.Text.IndexOf("."c) Then
            e.Handled = True ' Reject the character
        End If

        ' Check if the text is at the maximum length before the decimal
        If Not textBox_gas_price.Text.Contains(".") AndAlso textBox_gas_price.Text.Length >= 1 AndAlso Char.IsDigit(e.KeyChar) Then
            ' If the cursor is beyond the first digit, reject the character unless it's the decimal point
            If textBox_gas_price.SelectionStart > 1 OrElse (textBox_gas_price.SelectionStart = 1 AndAlso e.KeyChar <> "."c) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        resetInputBoxes()
    End Sub
End Class
