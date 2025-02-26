﻿#ExternalChecksum("..\..\..\UI\WallpaperElementX.xaml","{8829d00f-11b8-4213-878b-770e8597ac16}","227F3C129682BC43C81F8AEF4BDC04C20B5E6CA2B4734967F9D5CA3599077E36")
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
'''WallpaperElementX
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class WallpaperElementX
    Inherits System.Windows.Controls.UserControl
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\UI\WallpaperElementX.xaml",11)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents AnimeCover As System.Windows.Controls.Image
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\UI\WallpaperElementX.xaml",12)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents AnimeName As System.Windows.Controls.TextBlock
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\UI\WallpaperElementX.xaml",13)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents LibraryControls As System.Windows.Controls.Grid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\UI\WallpaperElementX.xaml",15)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents SetAsDesktopWallpaper As System.Windows.Controls.Image
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\UI\WallpaperElementX.xaml",20)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents SetAsLockscreen As System.Windows.Controls.Image
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\UI\WallpaperElementX.xaml",25)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents SetAsView As System.Windows.Controls.Image
    
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
        Dim resourceLocater As System.Uri = New System.Uri("/AniLife;component/ui/wallpaperelementx.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\UI\WallpaperElementX.xaml",1)
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
            Me.AnimeCover = CType(target,System.Windows.Controls.Image)
            Return
        End If
        If (connectionId = 2) Then
            Me.AnimeName = CType(target,System.Windows.Controls.TextBlock)
            Return
        End If
        If (connectionId = 3) Then
            Me.LibraryControls = CType(target,System.Windows.Controls.Grid)
            Return
        End If
        If (connectionId = 4) Then
            Me.SetAsDesktopWallpaper = CType(target,System.Windows.Controls.Image)
            Return
        End If
        If (connectionId = 5) Then
            Me.SetAsLockscreen = CType(target,System.Windows.Controls.Image)
            Return
        End If
        If (connectionId = 6) Then
            Me.SetAsView = CType(target,System.Windows.Controls.Image)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

