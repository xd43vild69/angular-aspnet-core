import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IProduct } from './product';

@Injectable({
  providedIn: 'root'
})
export class ProductoService {

  private apiURL = this.baseUrl + "api/product";

  //Peticiones http a WEBAPI
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getProducts(): Observable<IProduct[]> {
    return this.http.get<IProduct[]>(this.apiURL);
  }

}
