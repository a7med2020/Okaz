import { variable } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ApplicationUser,AuthResult,LoginResponse } from 'src/app/interfaces/applicationSecurity';
import { AuthManagementService} from 'src/app/services/APIs/applicationSecurity/auth-management.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  
  invalidLogin: boolean;
  _loginResponse: LoginResponse;
  ngOnInit(): void {
  }
  

  constructor(private authManagementService: AuthManagementService,private router: Router) {    }

  signIn(credentials) {

    const user : ApplicationUser ={
       email : credentials.email,
       userName : credentials.email,
       password : credentials.password
    };

    this.authManagementService.login(user)
    .subscribe(res => {this._loginResponse = res as LoginResponse;
      if(this._loginResponse && this._loginResponse.success){
        this.invalidLogin = false;
        localStorage.setItem('token', this._loginResponse.token);
        this.router.navigate(['/']);
      }
      else{
        this.invalidLogin = true;
        localStorage.removeItem('token');
      }
    });
  }

}




