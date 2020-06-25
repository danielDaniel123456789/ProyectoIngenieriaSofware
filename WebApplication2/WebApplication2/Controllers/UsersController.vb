Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports WebApplication2

Namespace Controllers
    Public Class UsersController
        Inherits System.Web.Mvc.Controller

        Private db As New vidly2Entities

        ' GET: Users
        Function Index() As ActionResult
            Return View(db.Users.ToList())
        End Function

        ' GET: Users/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim users As Users = db.Users.Find(id)
            If IsNothing(users) Then
                Return HttpNotFound()
            End If
            Return View(users)
        End Function

        ' GET: Users/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Users/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,Correo,Clave,Perfil,Idastate")> ByVal users As Users) As ActionResult
            If ModelState.IsValid Then
                db.Users.Add(users)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(users)
        End Function

        ' GET: Users/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim users As Users = db.Users.Find(id)
            If IsNothing(users) Then
                Return HttpNotFound()
            End If
            Return View(users)
        End Function

        ' POST: Users/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,Correo,Clave,Perfil,Idastate")> ByVal users As Users) As ActionResult
            If ModelState.IsValid Then
                db.Entry(users).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(users)
        End Function

        ' GET: Users/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim users As Users = db.Users.Find(id)
            If IsNothing(users) Then
                Return HttpNotFound()
            End If
            Return View(users)
        End Function

        ' POST: Users/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim users As Users = db.Users.Find(id)
            db.Users.Remove(users)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
