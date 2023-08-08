import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { Login } from './login'

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  private readonly API = 'https://localhost:7007/api/Admin'
  constructor(private http: HttpClient) { }

  validar(): Observable<Login>{
    return this.http.get<Login>(this.API)
  }

}