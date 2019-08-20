import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { map, finalize } from 'rxjs/operators';
import { AuthenticationModel } from 'src/app/models/authentication.model';
import { DataProvider } from 'src/app/providers/data.provider';


@Injectable({
  providedIn: 'root'
})
export class ClientdetailService {

  constructor(
    private http: HttpClient,
    public data: DataProvider) { }

    getClientDetail(){
      const url = `${environment.urlApi}/Insurance/${this.data.idclient}`;

      const options = {
        headers: new HttpHeaders({
          'Content-Type': 'application/json',
          //Authentication: this.data.token
        }),
      };

      return this.http.get(url, options).pipe(map((response: Response) => {
        return response;
      }), finalize(() => {
      }));

    }
}
