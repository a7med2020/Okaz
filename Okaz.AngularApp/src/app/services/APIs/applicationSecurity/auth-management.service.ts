import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { catchError, map, Observable, observable, throwError } from 'rxjs';
import { ApplicationUser, com, LoginResponse, RegistrationResponse } from 'src/app/interfaces/applicationSecurity';
import { JwtHelperService } from '@auth0/angular-jwt';
 
 
 

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type':  'application/json'
  })
};

const headers = { 'content-type': 'application/json'}  


@Injectable({
  providedIn: 'root'
})

  


export class AuthManagementService {
  currentUser: any;
  
  private apiUrl='http://localhost:5000/api/AuthManagement'
  constructor(private http:HttpClient, private jwthelper:JwtHelperService) { }

  register(applicationUser : ApplicationUser ): Observable<RegistrationResponse>{
    const url = `${this.apiUrl}/Register`;
    return this.http.post<RegistrationResponse>(url,applicationUser,httpOptions);
  }

  // login(applicationUser : ApplicationUser ): Observable<LoginResponse>{
  //   const url = `${this.apiUrl}/Login`;
  //   return this.http.post<LoginResponse>(url, applicationUser,httpOptions);
  // }


  login(applicationUser : ApplicationUser ){
    const url = `${this.apiUrl}/Login`;
    return this.http.post(url, applicationUser,httpOptions)
    .pipe(
      catchError(err => {
        console.log('err', err);
        return throwError('Something bad happened; please try again later.');
      }) 
      // let jwt = new JwtHelper();
      //   this.currentUser = jwt.decodeToken(localStorage.getItem('token'));
      )
     
  }


 logout() { 
    localStorage.removeItem('token');
    this.currentUser = null;
  }
  

  isLoggedIn() { 
    //alert(localStorage.getItem('token'));
    return !this.jwthelper.isTokenExpired(localStorage.getItem('token')??"");
  }

  // isLoggedIn() { 
  //   return tokenNotExpired('token');
  // }

//   deleteTask(task: Task): Observable<Task>{
//      const url = `${this.apiUrl}/${task.id}`;
//      return this.http.delete<Task>(url);
//   }

//   updateTaskReminder(task: Task): Observable<Task>{
//     const url = `${this.apiUrl}/${task.id}`;
//     return this.http.put<Task>(url,task,httpOptions);
//  }

//  addTask(task: Task): Observable<Task> {
//   return this.http.post<Task>(this.apiUrl, task, httpOptions);
// }


}
