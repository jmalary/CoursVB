﻿Public NotInheritable Class SplashScreen





    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Configurez le texte de la boîte de dialogue au moment de l'exécution en fonction des informations d'assembly de l'application.  


        '  boîte de dialogue Propriétés du projet (sous le menu "Projet").

        'Titre de l'application
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'Si le titre de l'application est absent, utilisez le nom de l'application, sans l'extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Mettez en forme les informations de version à l'aide du texte défini dans le contrôle de version au moment du design en tant que
        '  chaîne de mise en forme. Ceci permet une localisation efficace si besoin est.
        '  Les informations de génération et de révision peuvent être incluses en utilisant le code suivant et en remplaçant le 
        '  texte du contrôle de version par "Version {0}.{1:00}.{2}.{3}" ou un équivalent. Voir
        '  String.Format() dans l'aide pour plus d'informations.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Informations de copyright
        Copyright.Text = My.Application.Info.Copyright
    End Sub

End Class
