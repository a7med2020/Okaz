import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable, observable } from 'rxjs';
import { ApplicationUser, com, LoginResponse, RegistrationResponse } from 'src/app/interfaces/applicationSecurity';
 

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

  private apiUrl='http://localhost:5000/api/AuthManagement'
  constructor(private http:HttpClient) { }

  register(applicationUser : ApplicationUser ): Observable<RegistrationResponse>{
    const url = `${this.apiUrl}/Register`;
    return this.http.post<RegistrationResponse>(url,applicationUser,httpOptions);
  }

  login(applicationUser : ApplicationUser ): Observable<LoginResponse>{
     
    const url = `${this.apiUrl}/Login`;
     
    return this.http.post<LoginResponse>(url, applicationUser,httpOptions);
     
  }

  

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
