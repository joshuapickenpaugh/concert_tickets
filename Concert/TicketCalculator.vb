Public Class TicketCalculator

    Private _bolBox As Boolean
    Private _bolPav As Boolean
    Private _bolLawn As Boolean
    Private _intNumTixBox As Integer
    Private _intNumTixPav As Integer
    Private _intNumTixLawn As Integer
    Public Const INT_BOX_SEATS As Integer = 75
    Public Const INT_PAVILION_SEATS As Integer = 30
    Public Const INT_LAWN_SEATS As Integer = 21

    Public Property BolBox As Boolean
        Get
            Return _bolBox
        End Get
        Set(value As Boolean)
            If value = True Then
                _bolBox = value
            Else
                _bolBox = False
            End If
        End Set
    End Property

    Public Property BolPav As Boolean
        Get
            Return _bolPav
        End Get
        Set(value As Boolean)
            If value = True Then
                _bolPav = value
            Else
                _bolPav = False
            End If
        End Set
    End Property

    Public Property BolLawn As Boolean
        Get
            Return _bolLawn
        End Get
        Set(value As Boolean)
            If value = True Then
                _bolLawn = value
            Else
                _bolLawn = False
            End If
        End Set
    End Property

    Public Property NumTixBox As Integer
        Get
            Return _intNumTixBox
        End Get
        Set(value As Integer)
            If value > 0 Then
                _intNumTixBox = value
            Else
                _intNumTixBox = 0
            End If
        End Set
    End Property

    Public Property NumTixPav As Integer
        Get
            Return _intNumTixPav
        End Get
        Set(value As Integer)
            If value > 0 Then
                _intNumTixPav = value
            Else
                _intNumTixPav = 0
            End If
        End Set
    End Property

    Public Property NumTixLawn As Integer
        Get
            Return _intNumTixLawn
        End Get
        Set(value As Integer)
            If value > 0 Then
                _intNumTixLawn = value
            Else
                _intNumTixLawn = 0
            End If
        End Set
    End Property

    Public Sub New()

        _bolBox = False
        _bolPav = False
        _bolLawn = False
        _intNumTixBox = 0
        _intNumTixPav = 0
        _intNumTixLawn = 0

    End Sub

    Public Sub Clear()

        _bolBox = False
        _bolPav = False
        _bolLawn = False
        _intNumTixBox = 0
        _intNumTixPav = 0
        _intNumTixLawn = 0

    End Sub

    Public Function GetTotalNumTix() As Integer

        Dim numTix As Integer

        numTix = _intNumTixBox + _intNumTixPav + _intNumTixLawn

        Return numTix

    End Function

    Public Function GetTotalPrice() As Integer

        Dim ttlPrice As Integer

        If _bolBox = True Then
            ttlPrice = _intNumTixBox * INT_BOX_SEATS
        End If

        If _bolPav = True Then
            ttlPrice = ttlPrice + (_intNumTixPav * INT_PAVILION_SEATS)
        End If

        If _bolLawn = True Then
            ttlPrice = ttlPrice + (_intNumTixLawn * INT_LAWN_SEATS)
        End If

        Return ttlPrice

    End Function

End Class
