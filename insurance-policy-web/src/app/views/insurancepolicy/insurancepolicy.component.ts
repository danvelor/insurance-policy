import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { DataProvider } from 'src/app/providers/data.provider';
import { InsurancepolicyService } from './insurancepolicy.service';

@Component({
  selector: 'app-insurancepolicy',
  templateUrl: './insurancepolicy.component.html',
  styleUrls: ['./insurancepolicy.component.scss']
})
export class InsurancepolicyComponent implements OnInit {
  id = new FormControl('', [Validators.required]);
  name = new FormControl('', [Validators.required]);
  description = new FormControl('', [Validators.required]);
  
  coverage = new FormControl();
   x:any = {
    
  }
  coverageList: string[] = ['Extra cheese', 'Mushroom', 'Onion', 'Pepperoni', 'Sausage', 'Tomato'];

  constructor(
    public service: InsurancepolicyService,
    public data: DataProvider,
    public route: Router) { 
      

    }
  ngOnInit() {
  }

}
