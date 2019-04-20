import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IPersona } from './persona';

@Injectable({
  providedIn: 'root'
})
export class PersonasService {
  
  private apiURL = this.baseUrl + "api/persona";

  //Peticiones http a WEBAPI
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl:string) {}

  getPersonas(): Observable<IPersona[]> {
    return this.http.get<IPersona[]>(this.apiURL);
  }

  createPersona(persona: IPersona): Observable<IPersona> {
    return this.http.post<IPersona>(this.apiURL, persona);
  }

}
