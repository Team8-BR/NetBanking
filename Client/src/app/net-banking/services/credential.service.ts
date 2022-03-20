import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { map, Observable } from 'rxjs';

import { ResponseModel } from '../Models/ResponseModel';
@Injectable({
  providedIn: 'root'
})
export class CredentialService {
  private url = "http://localhost:17255/api/Credential"
  constructor(private _http : HttpClient) { }

  getAllaccount () : Observable<Credential[]> 
  {

    const responseObject = this._http.get(this.url);
// response from the get is in type Object 

   const mappedObservable : Observable<Credential[]> = responseObject
        .pipe(map(array =>  <Credential[]>array)) ;
    return mappedObservable 
 }

 getAccountbyId(id : number) : Observable<Credential> {

   const responseObject = this._http.get(`${this.url}/${id}`)
   const mappedObservableAccount : Observable<Credential> = responseObject.pipe(map(a => <Credential>a));
   return mappedObservableAccount
 } 

 addAccount(id : number  ): Observable<ResponseModel> {
   const responseObject = this._http.post(`${this.url}/${id}`, id )
   return responseObject.pipe(map((response: any) => <ResponseModel>response)) 
 }

 updateAccount(Account : Credential): Observable<ResponseModel> {
  const responseObject = this._http.put(`${this.url}`, Account)
  return responseObject.pipe(map((response: any) => <ResponseModel>response)) 
}

deleteAccount(id : number): Observable<ResponseModel> {
  const responseObject = this._http.put(`${this.url}`, id)
  return responseObject.pipe(map((response: any) => <ResponseModel>response)) 
}



} 
