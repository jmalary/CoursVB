Module Module1

    Sub Main()

        Dim x As Integer
        'appel à partir du même module
        proc_A()
        x = fonc_A()
        proc_B()
        unEspaceDeNoms.proc_A()



    End Sub

    Sub proc_A()
        MsgBox("procédure A")
    End Sub

    Function fonc_A() As Integer
        MsgBox("fonction A")
        Return 5
    End Function



End Module

Namespace unEspaceDeNoms
    Module module2
        Sub proc_A()
            MsgBox("procédure A du namespace unEspaceDeNoms")
        End Sub
    End Module
End Namespace



