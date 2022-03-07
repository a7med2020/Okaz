import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ApplicationUser } from 'src/app/interfaces/applicationSecurity';
import { AuthManagementService} from 'src/app/services/APIs/applicationSecurity/auth-management.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  
  invalidLogin: boolean;
  ngOnInit(): void {
  }
  

  constructor(private authManagementService: AuthManagementService) {    }

  signIn(credentials) {

    const user : ApplicationUser ={
       email : credentials.email,
       userName : credentials.email,
       password : credentials.password
    };

    var result = this.authManagementService.login(user);

    alert(result);

    this.invalidLogin = true; 
  }

}
