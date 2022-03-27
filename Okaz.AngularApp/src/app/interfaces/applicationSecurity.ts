export interface ApplicationUser {
    userName: string;
    email: string;
    password: string;
  }


  export interface AuthResult {
    token: string;
    refreshToken: string;
    success: boolean;
    errors: string[];

  }

  export interface com {
    ID: string;
    Nam: string;
    

  }

  export interface RegistrationResponse extends  AuthResult {}
  export interface LoginResponse extends  AuthResult {}


  