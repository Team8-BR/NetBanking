import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { map, Observable } from 'rxjs';
import { Account } from '../Models/Account';
@Injectable({
  providedIn: 'root'
})
export class AccountService {
  private url = "http://localhost:17255/api/Accounts"
  constructor(private _http : HttpClient) { }

  getAllaccount () : Observable<Account[]> {

    const responseObject = this._http.get(this.url);
// response from the get is in type Object 

   const mappedObservable : Observable<Account[]> = responseObject
        .pipe(map(array =>  <Account[]>array)) ;
    return mappedObservable
  }

}
