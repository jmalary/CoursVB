Imports System.Windows.Forms

Module Choix

    <Flags()> Enum typeOperateur
        ADD = 1 'addition
        SOU = 2 'soustraction
        MUL = 4 'multpilication
        DIV = 8 'division
        FAC = 16 'factorielle
        ORD = 32 'ordre 
    End Enum


 
    Sub Main()

        Dim sChoix As String 'chaîne servant de tampon de lecture
        Dim demarre As Boolean
        Dim quitter As Boolean
        Dim choix As Integer

        quitter = False


        Do While quitter = False



            sChoix = InputBox(vbTab & vbTab & vbTab & "M E N U " & vbCrLf & "======= " & vbCrLf & vbCrLf & "  1-  addition " & vbCrLf & " 2-  soustraire" & vbCrLf & " 3-  multiplication" & vbCrLf & " 4-  division" & vbCrLf & " 5-  factorielle" & vbCrLf & " 6-  trier trois valeur en ordre " & vbCrLf & " 7 - Quitter " & vbCrLf & vbCrLf & " Entrez votre choix ")

            'vbTab

            If Not IsNumeric(sChoix) Then
                MsgBox("Erreur")
            Else
                demarre = True
                Integer.TryParse(sChoix, choix)
                If choix <= 7 And choix >= 1 Then
                    demarre = True
                Else
                    demarre = False
                    MsgBox("Erreur chiffre")
                End If
            End If


            Dim msg As Boolean

            Select Case choix
               
                Case 1
                    Do
                        fctAddition()
                        msg = fonc_YesNo()
                    Loop Until msg = False


                Case 2
                    Do
                        fctSoustraction()
                        msg = fonc_YesNo()

                    Loop Until msg = False


                Case 3
                    Do
                        fctMultiplication()
                        msg = fonc_YesNo()

                    Loop Until msg = False

                Case 4
                    Do
                        fctDivison()
                        msg = fonc_YesNo()

                    Loop Until msg = False

                Case 5
                    Do
                        fctFactorielle()
                        msg = fonc_YesNo()

                    Loop Until msg = False

                Case 6
                    Do
                        fctOrdre()
                        msg = fonc_YesNo()

                    Loop Until msg = False

            End Select

            If choix = 7 Then
                quitter = True
            Else
                quitter = False
            End If
        Loop
    End Sub



    Function fonc_YesNo() As Boolean
        Dim rep As DialogResult
        Dim msg As Boolean

        rep = MessageBox.Show("Voulez vous faire un autre calcul", "Message", MessageBoxButtons.YesNo)


        If rep = DialogResult.Yes Then
            msg = True
        ElseIf rep = DialogResult.No Then
            msg = False
        End If

        Return msg

    End Function




End Module
