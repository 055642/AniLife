﻿#ExternalChecksum("..\..\Application.xaml","{8829d00f-11b8-4213-878b-770e8597ac16}","34F63A020E9ECC31BC81B8DC794EE1B41AA137FBF4D2B8552A49FD5E9AD14745")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports AniLife
Imports HandyControl.Controls
Imports HandyControl.Data
Imports HandyControl.Expression.Media
Imports HandyControl.Expression.Shapes
Imports HandyControl.Interactivity
Imports HandyControl.Media.Animation
Imports HandyControl.Media.Effects
Imports HandyControl.Properties.Langs
Imports HandyControl.Themes
Imports HandyControl.Tools
Imports HandyControl.Tools.Command
Imports HandyControl.Tools.Converter
Imports HandyControl.Tools.Extension
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''Application
'''</summary>
Partial Public Class Application
    Inherits System.Windows.Application
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent()
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        
        #ExternalSource("..\..\Application.xaml",6)
        Me.StartupUri = New System.Uri("MainWindow.xaml", System.UriKind.Relative)
        
        #End ExternalSource
        Dim resourceLocater As System.Uri = New System.Uri("/AniLife;component/application.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\Application.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    '''<summary>
    '''Application Entry Point.
    '''</summary>
    <System.STAThreadAttribute(),  _
     System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Shared Sub Main()
        Dim app As Application = New Application()
        app.InitializeComponent
        app.Run
    End Sub
End Class
