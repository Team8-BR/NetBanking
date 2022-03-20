import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { map, Observable } from 'rxjs';
import { Account } from '../Models/Account';
import { ResponseModel } from '../Models/ResponseModel';
@Injectable({
  providedIn: 'root'
})
export class AccountService {
  private url = "http://localhost:17255/api/Accounts"
  constructor(private _http : HttpClient) { }

  getAllaccount () : Observable<Account[]> 
  {

    const responseObject = this._http.get(this.url);
// response from the get is in type Object 

   const mappedObservable : Observable<Account[]> = responseObject
        .pipe(map(array =>  <Account[]>array)) ;
    return mappedObservable 
 }

 getAccountbyId(id : number) : Observable<Account> {

   const responseObject = this._http.get(`${this.url}/${id}`)
   const mappedObservableAccount : Observable<Account> = responseObject.pipe(map(a => <Account>a));
   return mappedObservableAccount
 } 

 addAccount(Account : Account ): Observable<ResponseModel> {
   const responseObject = this._http.post(`${this.url}`, Account)
   return responseObject.pipe(map((response: any) => <ResponseModel>response)) 
 }

 updateAccount(Account : Account): Observable<ResponseModel> {
  const responseObject = this._http.put(`${this.url}`, Account)
  return responseObject.pipe(map((response: any) => <ResponseModel>response)) 
}

deleteAccount(id : number): Observable<ResponseModel> {
  const responseObject = this._http.put(`${this.url}`, id)
  return responseObject.pipe(map((response: any) => <ResponseModel>response)) 
}



} 
