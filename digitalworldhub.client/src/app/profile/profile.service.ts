import { Injectable } from '@angular/core';
import { environment } from '../environments/environment';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProfileService {
  baseUrl = environment.apiUrl;
  constructor(private http: HttpClient) { }



  createProduct(productData: any) {
    return this.http.post<any>(this.baseUrl + 'profile/create', productData);
  }
}
