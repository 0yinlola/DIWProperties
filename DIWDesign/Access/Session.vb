Public Module Session
    Public Structure User
        'Manager = 1
        'Employee = 2
        'Customer = 3

        Dim User_id As Integer
        Dim Role As Integer
        Dim Username As String
        Dim FirstName As String
        Dim LastName As String
        Dim PhoneNumber As String
        Dim Email As String
        Dim Gender As String
        Dim Street1 As String
        Dim City As String
        Dim State As String
        Dim ZipCode As Integer
        Dim DOB As Date


        Function Clear() As Boolean
            User_id = 0
            Role = 0
            Username = ""
            FirstName = ""
            LastName = ""
            PhoneNumber = ""
            Email = ""
            Gender = ""
            Street1 = ""
            City = ""
            State = ""
            ZipCode = 0
            DOB = Today.Date
            Return True
        End Function

    End Structure

End Module
