Public Class Lister
    Sub Main()
        ' Create array of maximum index 3.
        Dim array(100) As String
        array(0) = "Select courant from Solde_encaisses_debut where numero = 1" 'proc_A() TextBox1
        array(1) = "Select courant from Apports where numero = 1" 'proc_B() TextBox12
        array(2) = "Select sept from Apports where numero = 1" 'proc_C()
        array(3) = "Select quatorze from Apports where numero = 1" 'proc_D()
        array(4) = "Select vingt from Apports where numero = 1" 'proc_E()
        array(5) = "Select courant from Retrait_manuel where numero = 1" 'proc_F()
        array(6) = "Select sept from Retrait_manuel where numero = 1" 'proc_G()
        array(7) = "Select quatorze from Retrait_manuel where numero = 1" 'proc_H()
        array(8) = "Select vingt from Retrait_manuel where numero = 1" 'proc_I()
        array(9) = "Select sum(un) from check_direct" 'proc_J()
        array(10) = "Select sum(deux) from check_direct" 'proc_K()
        array(11) = "Select sum(trois) from check_direct" 'proc_L()
        array(12) = "Select sum(quatre) from check_direct" 'proc_O()
        array(13) = "Select sum(un) from check_preautorises" 'proc_M()
        array(14) = "Select sum(deux) from check_preautorises" 'proc_N()
        array(15) = "Select sum(trois) from check_preautorises" 'proc_P()
        array(16) = "Select sum(quatre) from check_preautorises" 'proc_Q()
        array(17) = "Select sum(un) from check_emis" 'proc_R()
        array(18) = "Select sum(deux) from check_emis" 'proc_S()
        array(19) = "Select sum(trois) from check_emis" 'proc_T()
        array(20) = "Select sum(quatre) from check_emis" 'proc_U()
        array(21) = "Select courant from Salaires_paie_courante where numero = 1" 'proc_V()
        array(22) = "Select sept from Salaires_paie_courante where numero = 1" 'proc_W()
        array(23) = "Select quatorze from Salaires_paie_courante where numero = 1" 'proc_X()
        array(24) = "Select vingt from Salaires_paie_courante where numero = 1" 'proc_Y()
        array(25) = "Select courant from Argent_a_recevoir where numero = 1" 'proc_BA()
        array(26) = "Select sept from Argent_a_recevoir where numero = 1" 'proc_BB()
        array(27) = "Select quatorze from Argent_a_recevoir where numero = 1" 'proc_BC()
        array(28) = "Select vingt from Argent_a_recevoir where numero = 1" 'proc_BD()
        array(29) = "Select courant from marge_de_credit_utilise where numero = 1" 'proc_DA()
        array(30) = "Select courant from Encaisse_minimum_requise where numero = 1" 'proc_enc_min_req1()
        array(31) = "Select sept from Encaisse_minimum_requise where numero = 1" 'proc_enc_min_req2()
        array(32) = "Select quatorze from Encaisse_minimum_requise where numero = 1" 'proc_enc_min_req3()
        array(33) = "Select vingt from Encaisse_minimum_requise where numero = 1" 'proc_enc_min_req4()






        ' Display.
        For Each element As String In array
            Console.Write(element)
            Console.Write("... ")
        Next
    End Sub


End Class
