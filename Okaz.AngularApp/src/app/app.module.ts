import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import {FormsModule} from '@angular/forms'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { LoginComponent } from './components/applicationSecurity/login/login.component';

import { AnglrThemeComponent } from './components/themeTemplates/anglr-theme/anglr-theme.component';
import { MainThemeComponent } from './components/themeTemplates/main-theme/main-theme.component';
import {HttpClientModule} from '@angular/common/http';
import { TasksComponent } from './components/tasks/tasks.component';
import { HomeComponent } from './components/home/home.component'
 

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    AnglrThemeComponent,
    MainThemeComponent,
    TasksComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
     HttpClientModule,
    FormsModule,
    AppRoutingModule,
   
    RouterModule.forRoot([
      { path: '', component: HomeComponent },
      { path: 'login', component: LoginComponent },
      { path: 'themeTemplates/MainTheme/AnglrThemeComponent', component: AnglrThemeComponent },
      { path: 'themeTemplates/MainTheme/MainThemeComponent', component: MainThemeComponent },
    ]),
    NgbModule,
   
     
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
