export interface ApplicationUser {
    userName: string;
    email: string;
    password: string;
  }


  export interface AuthResult {
    Token: string;
    RefreshToken: string;
    Success: boolean;
    Errors: string[];

  }


  export interface RegistrationResponse extends  AuthResult {}
  export interface LoginResponse extends  AuthResult {}


  