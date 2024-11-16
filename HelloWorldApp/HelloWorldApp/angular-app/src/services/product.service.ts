import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from 'src/models/product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private apiUrl = 'https://localhost:5000/api/product/'; 

  constructor(private http: HttpClient) { }

  getProducts(): Observable<Product[]> {
    const url = this.apiUrl + 'GetAll';
    return this.http.get<Product[]>(url);
  }
}
