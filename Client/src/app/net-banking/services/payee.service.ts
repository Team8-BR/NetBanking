import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { Payee } from '../Models/Payee';
import { ResponseModel } from '../Models/ResponseModel';

@Injectable({
  providedIn: 'root'
})
export class PayeeService {
  private url = "http://localhost:17255/api/Payee"
  constructor(private _http : HttpClient) { }

  getAllPayee () : Observable<Payee[]> 
  {

    const responseObject = this._http.get(this.url);
// response from the get is in type Object 

   const mappedObservable : Observable<Payee[]> = responseObject
        .pipe(map(array =>  <Payee[]>array)) ;
    return mappedObservable 
 }

 getPayeebyId(id : number) : Observable<Payee> {

   const responseObject = this._http.get(`${this.url}/${id}`)
   const mappedObservablePayee : Observable<Payee> = responseObject.pipe(map(a => <Payee>a));
   return mappedObservablePayee
 } 

 addPayee(Payee : Payee ): Observable<ResponseModel> {
   const responseObject = this._http.post(`${this.url}`, Payee)
   return responseObject.pipe(map((response: any) => <ResponseModel>response)) 
 }

 updatePayee(Payee : Payee): Observable<ResponseModel> {
  const responseObject = this._http.put(`${this.url}`, Payee)
  return responseObject.pipe(map((response: any) => <ResponseModel>response)) 
}

deletePayee(id : number): Observable<ResponseModel> {
  const responseObject = this._http.put(`${this.url}`, id)
  return responseObject.pipe(map((response: any) => <ResponseModel>response)) 
}


}
