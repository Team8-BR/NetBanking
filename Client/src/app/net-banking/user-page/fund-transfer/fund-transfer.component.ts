import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-fund-transfer',
  templateUrl: './fund-transfer.component.html',
  styleUrls: ['./fund-transfer.component.css']
})
export class FundTransferComponent  {
  
  Beneficiaryinfo:FormGroup = this._bfi.group({
  BeneficiaryName:['',[Validators.required]],
  BeneficiaryAccountNumber:['',[Validators.required]],
  ReEnterAccountNumber:['',[Validators.required]],
})

IMPSpaymentinfo:FormGroup=this._imps.group({
  FromAccount:['',[Validators.required]],
  ToAccount:['',[Validators.required]],
  Amount:['',[Validators.required]],
  RecepientMobileNumber:['',[Validators.required]],
  TransactionDate:['',[Validators.required]],
  MaturityInstruction:['',[Validators.required]]
})
NEFTpaymentinfo:FormGroup=this._neft.group({
  FromAccount:['',[Validators.required]],
  ToAccount:['',[Validators.required]],
  Amount:['',[Validators.required]],
  TransactionDate:['',[Validators.required]]
})
RTGSpaymentinfo:FormGroup=this._rtgs.group({
  FromAccount:['',[Validators.required]],
  ToAccount:['',[Validators.required]],
  Amount:['',[Validators.required]],
  TransactionDate:['',[Validators.required]]
})
constructor(private _bfi:FormBuilder, 
           private _imps:FormBuilder,
           private _neft:FormBuilder,
           private _rtgs:FormBuilder){}

  

}
