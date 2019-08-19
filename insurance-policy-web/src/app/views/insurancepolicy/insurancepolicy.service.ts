import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { map, finalize } from 'rxjs/operators';
import { AuthenticationModel } from 'src/app/models/authentication.model';
import { DataProvider } from 'src/app/providers/data.provider';

@Injectable({
  providedIn: 'root'
})
export class InsurancepolicyService {

  constructor(
    private http: HttpClient,
    public data: DataProvider) { }
}
