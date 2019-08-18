import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataProvider {

  private TOKEN: string;

  public get token(): string {
    return this.TOKEN;
  }

  public set token(v: string) {
    this.TOKEN = v;
  }

}
