'Interface: jamais de donné membres
'les méthodes sont toutes des méthodes virtuelles pures (en-tête seulement)
'les classes qui vont implémenter cette interface devront définir ces méthodes
Public Interface IVivant
    ReadOnly Property age() As Integer
    Sub vieillir()
    Sub naitre()

End Interface
'on n'hérite jamais d'une interface: on l'implémente
'utilités:
'1) permet de contourner l'interdiction d'hériter de plusieurs classes
'donc une classe héritera d'une autre et pourra implémenter plusieurs interfaces

'2) oblige toutes les classes qui implémentent l'interface à définir ces méthodes
'avec le même nom et les mêmes paramètres (force une standardisation)
