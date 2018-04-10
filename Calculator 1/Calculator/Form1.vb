Public Class frmMain
    Dim input As Double
    Dim Sum As Double = 0
    Dim operation As Char
    Dim flag As Boolean = False
    Dim inputFlag As Boolean = False


    Private Sub frmMain_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Basic.Checked = False Then
            Exit Sub
        End If
        Select Case e.KeyCode
            Case Keys.D1
                btn1.PerformClick()
            Case Keys.D2
                btn2.PerformClick()
            Case Keys.D3
                btn3.PerformClick()
            Case Keys.D4
                btn4.PerformClick()
            Case Keys.D5
                btn5.PerformClick()
            Case Keys.D6
                btn6.PerformClick()
            Case Keys.D7
                btn7.PerformClick()
            Case Keys.D8
                btn8.PerformClick()
            Case Keys.D9
                btn9.PerformClick()
            Case Keys.D0
                btn0.PerformClick()
            Case Keys.Back
                btnDel.PerformClick()
        End Select
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If lbl.Text <> "0" Then
            Dim txt As String
            txt = lbl.Text
            lbl.Text = ""
            If txt.Length = 1 Then
                lbl.Text = "0"
            Else
                For i As Integer = 0 To txt.Length - 2 Step 1
                    lbl.Text = lbl.Text & txt.Chars(i)
                Next
            End If
        End If
        If lbl.Text.Length = 12 Then
            lbl.Font = New Font(lbl.Font.FontFamily, 20)
        End If
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        lblHelp.Visible = False
        If lbl.Text.Length = 16 Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            Exit Sub
        End If
       
        If lbl.Text <> "0" Then
            lbl.Text = lbl.Text & "7"
        Else
            lbl.Text = "7"
        End If
        inputFlag = True
        'If flag = False Then
        '    Sum = 0
        'End If
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        lblHelp.Visible = False
        If lbl.Text.Length = 16 Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            Exit Sub
        End If
        
        If lbl.Text <> "0" Then
            lbl.Text = lbl.Text & "8"
        Else
            lbl.Text = "8"
        End If
        inputFlag = True
        'If flag = False Then
        '    Sum = 0

        'End If

    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        lblHelp.Visible = False

        If lbl.Text.Length = 16 Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            Exit Sub
        End If
        
        If lbl.Text <> "0" Then
            lbl.Text = lbl.Text & "9"
        Else
            lbl.Text = "9"
        End If
        inputFlag = True
        'If flag = False Then
        '    Sum = 0

        'End If
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        lblHelp.Visible = False
        If lbl.Text.Length = 16 Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            Exit Sub
        End If
        'If lbl.Text.Length = 12 Then
        '    lbl.Font = New Font(lbl.Font.FontFamily, 15)
        'End If
        If lbl.Text <> "0" Then
            lbl.Text = lbl.Text & "4"
        Else
            lbl.Text = "4"
        End If
        inputFlag = True
        'If flag = False Then
        '    Sum = 0

        'End If
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        lblHelp.Visible = False
        If lbl.Text.Length = 16 Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            Exit Sub
        End If
        
        If lbl.Text <> "0" Then
            lbl.Text = lbl.Text & "5"
        Else
            lbl.Text = "5"
        End If
        inputFlag = True
        'If flag = False Then
        '    Sum = 0

        'End If
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        lblHelp.Visible = False
        If lbl.Text.Length = 16 Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            Exit Sub
        End If
        
        If lbl.Text <> "0" Then
            lbl.Text = lbl.Text & "6"
        Else
            lbl.Text = "6"
        End If
        inputFlag = True
        If flag = False Then
            Sum = 0

        End If
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        lblHelp.Visible = False
        If lbl.Text.Length = 16 Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            Exit Sub
        End If
        If lbl.Text <> "0" Then
            lbl.Text = lbl.Text & "1"
        Else
            lbl.Text = "1"
        End If
        inputFlag = True
        'If flag = False Then
        '    Sum = 0

        'End If
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        lblHelp.Visible = False

        If lbl.Text.Length = 16 Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            Exit Sub
        End If
        'If lbl.Text.Length = 12 Then
        '    lbl.Font = New Font(lbl.Font.FontFamily, 15)
        'End If
        If lbl.Text <> "0" Then
            lbl.Text = lbl.Text & "2"
        Else
            lbl.Text = "2"
        End If
        inputFlag = True
        'If flag = False Then
        '    Sum = 0

        'End If
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        lblHelp.Visible = False
        If lbl.Text.Length = 16 Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            Exit Sub
        End If
        
        If lbl.Text <> "0" Then
            lbl.Text = lbl.Text & "3"
        Else
            lbl.Text = "3"
        End If
        inputFlag = True
        'If flag = False Then
        '    Sum = 0

        'End If
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        lblHelp.Visible = False
        If lbl.Text.Length = 16 Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            Exit Sub
        End If
        'If lbl.Text.Length = 12 Then
        '    lbl.Font = New Font(lbl.Font.FontFamily, 15)
        'End If
        If lbl.Text <> "0" Then
            lbl.Text = lbl.Text & "0"
        End If
        inputFlag = True
        'If flag = False Then
        '    Sum = 0

        'End If
    End Sub

    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        lbl.Text = "0"
        lblHelp.Text = "0"
        lblInput.Text = ""
        Sum = 0
        flag = False
        inputFlag = False


    End Sub

    Private Sub btnCE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCE.Click
        lbl.Text = "0"
        lblHelp.Text = "0"
        If lblInput.Text = "" Then
            Sum = 0
        End If
    End Sub

    Private Sub btnDP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDP.Click

        If lblHelp.Visible = True And lblInput.Text = "" Then
            flag = False

            lbl.Text = "0"
            lblHelp.Visible = False
            lblHelp.Text = ""
            Sum = 0


        End If
        If lbl.Text.Length = 16 Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            Exit Sub
        End If
        If lbl.Text.Length = 12 Then
            lbl.Font = New Font(lbl.Font.FontFamily, 15)
        End If
        Dim localFlag As Boolean = False
        Dim txt As String = lbl.Text

        For i As Integer = 0 To txt.Length - 1 Step 1
            If txt.Chars(i) = "," Then
                localFlag = True
                Exit For
            End If
        Next
        If localFlag = False Then
            lbl.Text = lbl.Text & ","
        Else
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            Exit Sub
        End If

    End Sub

    Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
       
        If lblInput.Text = "" Then
            If flag = True Then
                lblInput.Text = Sum & " + "

                flag = False
            Else
                flag = True
                If input = 0 Then
                    lblInput.Text = Sum & " + "


                Else
                    lblInput.Text = lbl.Text & " + "
                    Sum = input
                    lbl.Text = Sum
                End If

            End If
        Else
            Dim txt As String = lblInput.Text
            Dim c As Char = txt.Chars(txt.Length - 1)
            If Char.IsDigit(c) <> True Then

                If txt.Chars(txt.Length - 2) <> "+" Then
                    If inputFlag Then
                        lblInput.Text = lblInput.Text & lbl.Text & " + "
                        Select Case operation
                            Case "+"
                                Sum += input
                            Case "-"
                                Sum -= input
                            Case "*"
                                Sum *= input
                            Case "/"
                                Sum /= input
                        End Select
                        lbl.Text = Sum
                    Else
                        lblInput.Text = ""
                        For i As Integer = 0 To txt.Length - 3 Step 1
                            lblInput.Text = lblInput.Text & txt.Chars(i)
                        Next
                        lblInput.Text = lblInput.Text & "+ "

                    End If

                Else
                    If inputFlag Then
                        lblInput.Text = lblInput.Text & lbl.Text & " + "
                        Sum = Sum + input

                        lbl.Text = Sum
                    Else
                        Exit Sub
                    End If

                End If

            Else
                lblInput.Text = lblInput.Text & " " & lbl.Text & " + "
                Sum = Sum + input

                lbl.Text = Sum

            End If

        End If

            lblHelp.Visible = True
            lblHelp.Text = Sum
            lbl.Text = "0"
        operation = "+"
        inputFlag = False

    End Sub

    Private Sub btnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click
       
        If lblInput.Text = "" Then
            If flag Then
                lblInput.Text = Sum & " - "

                flag = False
            Else
                flag = True
                If input = 0 Then
                    lblInput.Text = Sum & " - "


                Else
                    lblInput.Text = lbl.Text & " - "
                    Sum = input
                    lbl.Text = Sum
                End If
            End If


        Else
            Dim txt As String = lblInput.Text
            Dim c As Char = txt.Chars(txt.Length - 1)
            If Char.IsDigit(c) <> True Then

                If txt.Chars(txt.Length - 2) <> "-" Then
                    If inputFlag Then
                        lblInput.Text = lblInput.Text & lbl.Text & " - "
                        Select Case operation
                            Case "+"
                                Sum += input
                            Case "-"
                                Sum -= input
                            Case "*"
                                Sum *= input
                            Case "/"
                                Sum /= input
                        End Select
                        lbl.Text = Sum
                    Else
                        lblInput.Text = ""
                        For i As Integer = 0 To txt.Length - 3 Step 1
                            lblInput.Text = lblInput.Text & txt.Chars(i)
                        Next
                        lblInput.Text = lblInput.Text & "- "
                    End If


                Else
                    If inputFlag Then
                        lblInput.Text = lblInput.Text & lbl.Text & " - "
                        Sum = Sum - input
                        lbl.Text = Sum
                    Else
                        Exit Sub

                    End If


                End If

            Else
                lblInput.Text = lblInput.Text & " " & lbl.Text & " - "
                Sum = Sum - input
                lbl.Text = Sum

            End If

        End If


        lblHelp.Visible = True
        lblHelp.Text = Sum
        lbl.Text = ""
        operation = "-"
        inputFlag = False
    End Sub

    Private Sub btnMultiplied_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiplied.Click
        If Sum = 0 And flag <> True Then
            Sum = 1
        End If
        If lblInput.Text = "" Then
            If flag Then
                lblInput.Text = Sum & " * "

                flag = False
            Else
                flag = True
                If input = 0 Then
                    lblInput.Text = Sum & " * "


                Else
                    lblInput.Text = lbl.Text & " * "
                    Sum = input
                    lbl.Text = Sum
                End If
            End If


        Else
            Dim txt As String = lblInput.Text
            Dim c As Char = txt.Chars(txt.Length - 1)
            If Char.IsDigit(c) <> True Then

                If txt.Chars(txt.Length - 2) <> "*" Then

                    If inputFlag Then
                        lblInput.Text = lblInput.Text & lbl.Text & " * "
                        Select Case operation
                            Case "+"
                                Sum += input
                            Case "-"
                                Sum -= input
                            Case "*"
                                Sum *= input
                            Case "/"
                                Sum /= input
                        End Select


                        lbl.Text = Sum
                    Else
                        lblInput.Text = ""
                        For i As Integer = 0 To txt.Length - 3 Step 1
                            lblInput.Text = lblInput.Text & txt.Chars(i)
                        Next
                        lblInput.Text = lblInput.Text & "* "
                    End If


                Else
                    If inputFlag Then
                        lblInput.Text = lblInput.Text & lbl.Text & " * "
                        Sum = Sum * input
                        lbl.Text = Sum
                    Else
                        Exit Sub
                    End If



                End If

            Else
                lblInput.Text = lblInput.Text & " " & lbl.Text & " * "
                Sum = Sum * input
                lbl.Text = Sum

            End If

        End If
        lblHelp.Visible = True
        lblHelp.Text = Sum
        lbl.Text = ""
        operation = "*"
        inputFlag = False
    End Sub

    Private Sub btnDevided_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevided.Click
        If Sum = 0 And flag <> True Then
            Sum = 1
        End If
        If lblInput.Text = "" Then
            If flag Then
                lblInput.Text = Sum & " / "

                flag = False
            Else
                flag = True
                If input = 0 Then
                    lblInput.Text = Sum & " / "


                Else
                    lblInput.Text = lbl.Text & " / "
                    Sum = input
                    lbl.Text = Sum
                End If
            End If


        Else
            Dim txt As String = lblInput.Text
            Dim c As Char = txt.Chars(txt.Length - 1)
            If Char.IsDigit(c) <> True Then

                If txt.Chars(txt.Length - 2) <> "/" Then
                    If inputFlag Then
                        lblInput.Text = lblInput.Text & lbl.Text & " / "
                        Select Case operation
                            Case "+"
                                Sum += input
                            Case "-"
                                Sum -= input
                            Case "*"
                                Sum *= input
                            Case "/"
                                Sum /= input
                        End Select
                        lbl.Text = Sum
                    Else
                        lblInput.Text = ""
                        For i As Integer = 0 To txt.Length - 3 Step 1
                            lblInput.Text = lblInput.Text & txt.Chars(i)
                        Next
                        lblInput.Text = lblInput.Text & "/ "
                    End If


                Else
                    If inputFlag Then
                        lblInput.Text = lblInput.Text & lbl.Text & " / "
                        Sum = Sum / input
                        lbl.Text = Sum
                    Else
                        Exit Sub

                    End If


                End If

            Else
                lblInput.Text = lblInput.Text & " " & lbl.Text & " / "
                Sum = Sum / input
                lbl.Text = Sum

            End If

        End If
        lblHelp.Visible = True
        lblHelp.Text = Sum
        lbl.Text = ""
        operation = "/"
        inputFlag = False
    End Sub
    Private Sub DigitGrouping_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DigitGrouping.CheckedChanged
        If DigitGrouping.Checked = False Then
            Dim n As String = ""
            For i As Integer = 0 To lblHelp.Text.Length - 1 Step 1
                If lblHelp.Text.Chars(i) = "," Then
                    n = n & "."
                Else
                    n = n & lblHelp.Text.Chars(i)
                End If
            Next
            Dim num As Double = Val(n)
            'lbl.Text = Format(num, "################.################")
            lblHelp.Text = Format(num, "################.################")
        End If
    End Sub

    Private Sub tmrFontSize_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFontSize.Tick
        If lblHelp.Text.Length <= 12 Then
            lblHelp.Font = New Font(lblHelp.Font.FontFamily, 20)
        ElseIf lbl.Text.Length > 12 And lbl.Text.Length <= 16 Then
            lblHelp.Font = New Font(lblHelp.Font.FontFamily, 15)
        Else
            lblHelp.Font = New Font(lblHelp.Font.FontFamily, 13)
        End If
        If lblHelp.Text.Length <= 12 Then
            lblHelp.Font = New Font(lblHelp.Font.FontFamily, 20)
        ElseIf lblHelp.Text.Length > 12 And lblHelp.Text.Length <= 16 Then
            lblHelp.Font = New Font(lblHelp.Font.FontFamily, 15)
        Else
            lblHelp.Font = New Font(lblHelp.Font.FontFamily, 13)
        End If
        If DigitGrouping.Checked = True Then
            Dim n As String = ""
            For i As Integer = 0 To lblHelp.Text.Length - 1 Step 1
                If lblHelp.Text.Chars(i) = "," Then
                    n = n & "."
                Else
                    n = n & lblHelp.Text.Chars(i)
                End If
            Next

            Dim num As Double = Val(n)
            lblHelp.Text = Format(num, "# ### ### ### ### ###.################")
        End If


        Label1.Text = Sum & ";" & input & " ; " & operation
        'Label2.Text = 1 / 0.333333333333333
        Label3.Text = flag

        If lbl.Text.Length <= 12 Then
            lbl.Font = New Font(lbl.Font.FontFamily, 20)
        ElseIf lbl.Text.Length > 12 And lbl.Text.Length <= 16 Then
            lbl.Font = New Font(lbl.Font.FontFamily, 15)
        Else
            lbl.Font = New Font(lbl.Font.FontFamily, 13)
        End If
        If DigitGrouping.Checked = True Then
            Dim n As String = ""
            For i As Integer = 0 To lbl.Text.Length - 1 Step 1
                If lbl.Text.Chars(i) = "," Then
                    n = n & "."
                Else
                    n = n & lbl.Text.Chars(i)
                End If
            Next

            Dim num As Double = Val(n)
            lbl.Text = Format(num, "# ### ### ### ### ###.################")
        End If

    End Sub

    Private Sub tmrInput_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrInput.Tick
        Dim n As String = ""
        For i As Integer = 0 To lbl.Text.Length - 1 Step 1
            If lbl.Text.Chars(i) = "," Then
                n = n & "."
            Else
                n = n & lbl.Text.Chars(i)
            End If
        Next
        input = Val(n)

    End Sub

    Private Sub btnEquals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquals.Click
        Select Case operation
            Case "+"
                If inputFlag = False Then
                    If lblInput.Text = "" Then
                        Exit Select
                    Else
                        Sum += Sum
                    End If

                Else
                    Sum += input
                End If

            Case "-"
                If inputFlag = False Then
                    Sum -= Sum
                Else
                    Sum -= input
                End If
            Case "*"
                If inputFlag = False Then
                    Sum *= Sum
                Else
                    Sum *= input
                End If
            Case "/"
                If inputFlag = False Then
                    Sum /= Sum
                Else
                    Sum /= input
                End If
            Case ""
                Sum = input

        End Select
        flag = True
        lblInput.Text = ""
        lblHelp.Visible = True
        lblHelp.Text = Sum
        'Sum = 0

        lbl.Text = ""
        inputFlag = False
    End Sub

    Private Sub UnitConvertion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Basic.Checked = False
        DateCalculation.Checked = False

        Me.Width = 602
        Me.Size = Me.MaximumSize

        gbDateCalculation.Visible = False


    End Sub

    Private Sub Basic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Basic.Click
        Basic.Checked = True

        DateCalculation.Checked = False
        Me.Size = Me.MinimumSize
        gbDateCalculation.Visible = False
       
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = Me.MinimumSize
        Basic.Checked = True

    End Sub

    Private Sub DateCalculation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateCalculation.Click
        Me.Size = Me.MaximumSize
        Basic.Checked = False

        DateCalculation.Checked = True
        gbDateCalculation.Visible = True
    End Sub

    Private Sub btnPM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPM.Click
        If lblHelp.Visible = True Then
            If flag Then
                Sum *= -1
                lblHelp.Text = Sum
                lbl.Text = ""

            Else
                Select Case operation
                    Case "+"
                        Sum += Sum * -1
                    Case "-"
                        Sum -= Sum * -1
                    Case "*"
                        Sum *= -1
                    Case "/"
                        Sum /= -1
                End Select
                lblHelp.Text = Val(lblHelp.Text) * -1.0
                lbl.Text = ""
                flag = False
            End If
        Else
            lbl.Text = Val(lbl.Text) * -1.0
            flag = False
        End If
    End Sub

    Private Sub btnRP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRP.Click
        
        If lblHelp.Visible = True Then
            lblHelp.Text = 1 / Sum
            input = 1 / Sum
        Else
            lbl.Text = 1 / input
            input = 1 / input
        End If
        inputFlag = False

    End Sub

    Private Sub btnSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSqrt.Click

        If lblHelp.Visible = True Then
            If flag Then
                Sum = System.Math.Sqrt(Sum)
                lblHelp.Text = Sum
                lbl.Text = ""

            Else
                Select Case operation
                    Case "+"
                        Sum += System.Math.Sqrt(Sum)
                    Case "-"
                        Sum -= System.Math.Sqrt(Sum)
                    Case "*"
                        Sum *= System.Math.Sqrt(Sum)
                    Case "/"
                        Sum /= System.Math.Sqrt(Sum)
                End Select
                lblHelp.Text = System.Math.Sqrt(Val(lblHelp.Text))
                lbl.Text = ""
                flag = False
            End If


        Else
            lbl.Text = System.Math.Sqrt(Val(lbl.Text))
            flag = False
        End If

    End Sub

    Private Sub cmbCalculationType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCalculationType.SelectedIndexChanged
        Select Case cmbCalculationType.SelectedItem
            Case "Calculate the difference between two dates"
                gbDifferenceCalculation.Visible = True
                gbAddSubtract.Visible = False
            Case "Add or subtract days to a specified date"
                gbAddSubtract.Visible = True
                gbDifferenceCalculation.Visible = False

        End Select
    End Sub

    Private Sub btnAddSubstract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSubstract.Click
        Dim d As Date = dateAddSubtract.Value


        If rbAdd.Checked = True Then
            d = d.AddYears(nudYear.Value)
            d = d.AddMonths(nudMonth.Value)
            d = d.AddDays(nudDay.Value)
            lblAddSubtract.Text = Format(d, "dd MMMM yyyy г.")
        End If

        If rbSubtract.Checked = True Then
          
            d = d.AddYears(nudYear.Value * -1)
            d = d.AddMonths(nudMonth.Value * -1)
            d = d.AddDays(nudDay.Value * -1)
            lblAddSubtract.Text = Format(d, "dd MMMM yyyy г.")
        End If


    End Sub

    Private Sub nudYear_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudYear.ValueChanged
        lblAddSubtract.Text = ""

    End Sub

    Private Sub nudMonth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudMonth.ValueChanged
        lblAddSubtract.Text = ""
    End Sub

    Private Sub nudDay_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudDay.ValueChanged
        lblAddSubtract.Text = ""
    End Sub

    Private Sub rbAdd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAdd.CheckedChanged
        lblAddSubtract.Text = ""
    End Sub

    Private Sub rbSubtract_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSubtract.CheckedChanged
        lblAddSubtract.Text = ""
    End Sub

    Private Sub dateAddSubtract_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateAddSubtract.ValueChanged
        lblAddSubtract.Text = ""
    End Sub

    Private Sub gbAddSubtract_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbAddSubtract.VisibleChanged
        lblAddSubtract.Text = ""
        dateAddSubtract.Value = Now
        nudDay.Value = 0
        nudMonth.Value = 0
        nudYear.Value = 0
        rbAdd.Checked = False
        rbSubtract.Checked = False


    End Sub

    Private Sub gbDifferenceCalculation_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbDifferenceCalculation.VisibleChanged
        dateFrom.Value = Now
        dateTo.Value = Now
        differenceY.Text = ""
        differenceW.Text = ""

    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim date1, date2 As New Date
        date1 = dateFrom.Value
        date2 = dateTo.Value

        Dim y, m, w, d As Integer
        y = Math.Abs(DateDiff(DateInterval.Year, date1, date2))
        m = Math.Abs(DateDiff(DateInterval.Month, date1, date2))
        w = Math.Abs(DateDiff(DateInterval.Weekday, date1, date2))
        d = Math.Abs(DateDiff(DateInterval.Day, date1, date2))
        differenceD.Text = ""
        differenceM.Text = ""
        differenceW.Text = ""
        differenceY.Text = ""



        differenceY.Text = differenceY.Text & y & " year"
            If y > 1 Then
                differenceY.Text &= "s"
            End If
      
        differenceM.Text = differenceM.Text & m & " month"
            If m > 1 Then
                differenceM.Text &= "s"
            End If

        
        differenceW.Text = differenceW.Text & w & " week"
            If w > 1 Then
                differenceW.Text &= "s"
            End If

       
        differenceD.Text = differenceD.Text & d & " day"
            If d > 1 Then
                differenceD.Text &= "s"
            End If
        'If y > 0 Then
        '    differenceYMWD.Text &= y & " year"
        '    If y > 1 Then
        '        differenceYMWD.Text &= "s;"
        '    Else
        '        differenceYMWD.Text &= ";"
        '    End If
        'End If

        'If m > 0 Then
        '    differenceYMWD.Text &= y & " month"
        '    If m > 1 Then
        '        differenceYMWD.Text &= "s;"
        '    Else
        '        differenceYMWD.Text &= ";"
        '    End If
        'End If
        'If w > 0 Then
        '    differenceYMWD.Text &= y & " week"
        '    If w > 1 Then
        '        differenceYMWD.Text &= "s;"
        '    Else
        '        differenceYMWD.Text &= ";"
        '    End If
        'End If
        'If d > 0 Then
        '    differenceYMWD.Text &= y & " day"
        '    If d > 1 Then
        '        differenceYMWD.Text &= "s"
        '    End If
        'End If

    End Sub
End Class