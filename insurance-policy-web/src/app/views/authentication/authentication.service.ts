import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { map, finalize } from 'rxjs/operators';
import { AuthenticationModel } from 'src/app/models/authentication.model';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private http: HttpClient) { }

  public login(body: AuthenticationModel) {
    const url = `${environment.urlApi}`;
    
    const options = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json'
        }),
    };

    return this.http.post(url, body, options).pipe(map((response: Response) => {
        return response;
    }), finalize(() => {
    }));
}
}
