﻿#ExternalChecksum("..\..\..\UI\AnimeElementXTip.xaml","{8829d00f-11b8-4213-878b-770e8597ac16}","868805EE58057DEE6CD98F76CA3411469D5626E3EA8205427523AC82B09C7938")
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
'''AnimeElementXTip
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class AnimeElementXTip
    Inherits System.Windows.Controls.UserControl
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\UI\AnimeElementXTip.xaml",11)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents AirDate As System.Windows.Controls.TextBlock
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\UI\AnimeElementXTip.xaml",12)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Score As System.Windows.Controls.TextBlock
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\UI\AnimeElementXTip.xaml",14)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents StudioName As System.Windows.Controls.TextBlock
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\UI\AnimeElementXTip.xaml",15)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents TypexEpisodes As System.Windows.Controls.TextBlock
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\UI\AnimeElementXTip.xaml",16)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Tags As System.Windows.Controls.WrapPanel
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/AniLife;component/ui/animeelementxtip.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\UI\AnimeElementXTip.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.AirDate = CType(target,System.Windows.Controls.TextBlock)
            Return
        End If
        If (connectionId = 2) Then
            Me.Score = CType(target,System.Windows.Controls.TextBlock)
            Return
        End If
        If (connectionId = 3) Then
            Me.StudioName = CType(target,System.Windows.Controls.TextBlock)
            Return
        End If
        If (connectionId = 4) Then
            Me.TypexEpisodes = CType(target,System.Windows.Controls.TextBlock)
            Return
        End If
        If (connectionId = 5) Then
            Me.Tags = CType(target,System.Windows.Controls.WrapPanel)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class
