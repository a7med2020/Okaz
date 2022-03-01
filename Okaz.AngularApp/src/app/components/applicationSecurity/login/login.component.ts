import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  
  invalidLogin: boolean;
  ngOnInit(): void {
  }
  

  constructor(
    private router: Router) {    }

  signIn(credentials) {
   
    this.invalidLogin = true; 
  }

}
