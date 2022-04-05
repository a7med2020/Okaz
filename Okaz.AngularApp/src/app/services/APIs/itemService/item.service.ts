import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { item } from 'src/app/interfaces/Item';

@Injectable({
  providedIn: 'root'
})
export class ItemService {
  itemList: item[];
  private baseURL='http://localhost:5000/api/Home'

  constructor(private http:HttpClient) { }
   
  refreshList() {
    const url = `${this.baseURL}/GetAll`;
    this.http.get(url)
      .toPromise()
      .then(res =>this.itemList = res as item[]);
  }
  
}
