Imports System.Net
Imports System.Web.Http
Imports Sfarm.DAL.Entities.Prescriptions

Namespace Controllers
    Public Class PrescriptionsStatusSetController
        Inherits ApiController

        Public Function GetValues() As String
            Return "PrescriptionsStatusSetController"
        End Function

        <HttpPost>
        Public Sub PostValue(<FromBody()> ByVal prescriptionStatus As RequestPrescriptionStatus)
            If System.Web.HttpContext.Current.Request.Headers.Get(HttpRequestHeader.Authorization.ToString) IsNot Nothing AndAlso
               String.Compare(System.Web.HttpContext.Current.Request.Headers.Get(HttpRequestHeader.Authorization.ToString), PrescriptionsHelpers.authToken, True) = 0 Then

                Try
                    If prescriptionStatus Is Nothing OrElse String.IsNullOrEmpty(prescriptionStatus.prescriptionId) Then
                        DataHelper.GetJsonResultWithStatusCode("Structure parsing error", HttpStatusCode.BadRequest)
                    Else
                        Dim rd As Sfarm.DAL.Entities.ResponseData = Sfarm.DAL.Helpers.PrescriptionHelper.PrescriptionsStatusSet(prescriptionStatus)

                        If rd Is Nothing OrElse rd.IsError Then
                            If rd.Data IsNot Nothing AndAlso rd.Data.GetType Is GetType(String) AndAlso Not String.IsNullOrEmpty(rd.Data) Then
                                DataHelper.GetJsonResultWithStatusCode(rd.Data, HttpStatusCode.BadRequest)
                            Else
                                DataHelper.GetJsonResultWithStatusCode(prescriptionStatus.prescriptionId, HttpStatusCode.InternalServerError)
                            End If
                        Else
                            DataHelper.GetJsonResultWithStatusCode(prescriptionStatus.prescriptionId, HttpStatusCode.OK)
                        End If
                    End If
                Catch
                    DataHelper.GetJsonResultWithStatusCode("Internal server error", HttpStatusCode.InternalServerError)
                End Try
            Else
                DataHelper.GetJsonResultWithStatusCode("Bad autorizization token", HttpStatusCode.Unauthorized)
            End If
        End Sub

    End Class
End Namespace