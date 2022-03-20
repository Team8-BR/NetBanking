import { Component, OnInit} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { Account } from '../../Models/Account';
import { AccountService } from '../../services/account.service';

@Component({
  selector: 'app-fund-transfer',
  templateUrl: './fund-transfer.component.html',
  styleUrls: ['./fund-transfer.component.css']
})
export class FundTransferComponent  {
  
  Beneficiaryinfo:FormGroup = this._bfi.group({
  beneficiaryname:['',[Validators.required]],
  beneficiaryaccountnumber:['',[Validators.required]],
  reenteraccountnumber:['',[Validators.required]],
  nickname:['']
})

IMPSpaymentinfo:FormGroup=this._imps.group({
  fromaccount:['',[Validators.required]],
  Toaccount:['',[Validators.required]],
  amount:['',[Validators.required]],
  recepientmobilenumber:['',[Validators.required]],
  transactiondate:['',[Validators.required]],
  maturityinstructions:['',[Validators.required]],
  remarks:['']
})
NEFTpaymentinfo:FormGroup=this._neft.group({
  fromaccount:['',[Validators.required]],
  Toaccount:['',[Validators.required]],
  amount:['',[Validators.required]],
  transactiondate:['',[Validators.required]],
  remarks:['']
})
RTGSpaymentinfo:FormGroup=this._rtgs.group({
  fromaccount:['',[Validators.required]],
  Toaccount:['',[Validators.required]],
  amount:['',[Validators.required]],
  transactiondate:['',[Validators.required]],
  remarks:['']
})
Account? : Account

constructor(private _bfi:FormBuilder, 
           private _imps:FormBuilder,
           private _neft:FormBuilder,
           private _rtgs:FormBuilder,private _as : AccountService, private route : ActivatedRoute ){}

  

           ngOnInit(): void {
            const routeParams = this.route.snapshot.paramMap;
            const customerIdFromRoute = Number(routeParams.get('customerId'));
            const ObservableAccount : Observable<Account> = this._as.getAccountbyId(customerIdFromRoute)
            ObservableAccount.subscribe(
              (Accounts : Account) => this.Account = Accounts )
          }
        

           

}
