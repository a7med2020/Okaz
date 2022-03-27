import { Injectable } from '@angular/core';
import { Router, CanActivate } from '@angular/router';
import { AuthManagementService } from './APIs/applicationSecurity/auth-management.service';

@Injectable()
export class AuthGuard implements CanActivate {

constructor(protected router: Router, protected authService: AuthManagementService) { }
 
  canActivate() {
    if (this.authService.isLoggedIn()) return true;

    this.router.navigate(['/login']);
    return false;
  }
}

