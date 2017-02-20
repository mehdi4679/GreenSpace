//using Microsoft.VisualBasic;
//using Microsoft.Reporting.WebForms;
//using System.Net;
//using System.SerializableAttribute;

//Public Class ReportServerCredentials
//    Implements IReportServerCredentials

//    Public Sub New()

//    End Sub

//    Public Function GetFormsCredentials(ByRef authCookie As System.Net.Cookie, ByRef userName As String, ByRef password As String, ByRef authority As String) As Boolean Implements Microsoft.Reporting.WebForms.IReportServerCredentials.GetFormsCredentials
//        authCookie = Nothing
//        userName = Nothing
//        password = Nothing
//        authority = Nothing

//        'Not using form credentials
//        Return False
//    End Function

//    Public ReadOnly Property ImpersonationUser() As System.Security.Principal.WindowsIdentity Implements Microsoft.Reporting.WebForms.IReportServerCredentials.ImpersonationUser
//        Get
//            'Use the default Windows user. Credentials will be
//            'provided by the NetworkCredentials property.
//            Return Nothing
//        End Get
//    End Property

//    Public ReadOnly Property NetworkCredentials() As System.Net.ICredentials Implements Microsoft.Reporting.WebForms.IReportServerCredentials.NetworkCredentials
//        Get
             
//            Dim userName As String = ConfigurationManager.AppSettings("ReportUser")
//            If String.IsNullOrEmpty(userName) Then
//                Throw New Exception("Missing user name in web.config file")
//            End If

//            Dim password As String = ConfigurationManager.AppSettings("ReportUserPass")
//            If String.IsNullOrEmpty(password) Then
//                Throw New Exception("Missing password in web.config file")
//            End If

//            Dim domain As String = ConfigurationManager.AppSettings("Domain")
//            If String.IsNullOrEmpty(domain) Then
//                'Throw New Exception("Missing domain in web.config file")

//            End If

//            Return New NetworkCredential(userName, password, domain)
//        End Get
//    End Property
//End Class

