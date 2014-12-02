Imports Cirrious.MvvmCross.ViewModels

Namespace ViewModels
    Public Interface ICaluculation
        Function TipAmount(subTotal As Double, generosity As Integer) As Double
    End Interface

    Public Class Calculation
        Implements ICaluculation

        Public Function TipAmount(subTotal As Double, generosity As Integer) As Double Implements ICaluculation.TipAmount
            Return subTotal * CType(generosity, Double) / 100.0
        End Function
    End Class

    Public Class TipViewModel
        Inherits MvxViewModel

        Private _calculation As ICaluculation
        Public Sub New()
            _calculation = New Calculation()
            Start()
        End Sub

        Public Overloads Sub Start()
            _subTotal = 100.0
            _generosity = 10
            Me.Recalcuate()
            MyBase.Start()
        End Sub


        Private _subTotal As Double
        Private _generosity As Integer
        Private _tip As Double

        Public Property SubTotal As Double
            Get
                Return _subTotal
            End Get
            Set(value As Double)
                _subTotal = value
                RaisePropertyChanged(Function() SubTotal)
                Recalcuate()
            End Set
        End Property

        Public Property Generosity As Integer
            Get
                Return _generosity
            End Get
            Set(value As Integer)
                _generosity = value
                RaisePropertyChanged(Function() Generosity)
                Recalcuate()
            End Set
        End Property

        Public Property Tip As Double
            Get
                Return _tip
            End Get
            Set(value As Double)
                _tip = value
                RaisePropertyChanged(Function() Tip)
            End Set
        End Property

        Private Sub Recalcuate()
            Tip = _calculation.TipAmount(SubTotal, Generosity)
        End Sub
    End Class
End Namespace
