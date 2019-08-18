import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { AuthenticationService } from './authentication.service';
import { AuthenticationModel } from 'src/app/models/authentication.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-authentication',
  templateUrl: './authentication.component.html',
  styleUrls: ['./authentication.component.scss']
})
export class AuthenticationComponent implements OnInit {

  user = new FormControl('', [Validators.required]);
  password = new FormControl('', [Validators.required]);

  constructor(public service: AuthenticationService, public router: Router) { }

  ngOnInit() {
  }

  login() {

    const body: AuthenticationModel ={   
      user: this.user.value,
      password: this.password.value
    };


    this.service.login(body).subscribe((response: any) => {
      console.log(response);
      const json = atob(response.token);
      const obj = JSON.parse(json);
      console.log(obj);
      this.router.navigate(['clients']);
    }, (e: any) => {  
      console.log(e);
    })

  }

}
