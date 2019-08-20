import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataProvider {

  private TOKEN: string;
  private IDCLIENT: string
  private NAMECLIENT: string

  public get token(): string {
    return this.TOKEN;
  }

  public set token(v: string) {
    this.TOKEN = v;
  }

  public get idclient():string{
    return this.IDCLIENT;
  }

  public set idclient(v:string){
    this.IDCLIENT = v;
  }

  public get nameclient():string{
    return this.NAMECLIENT;
  }

  public set nameclient(v:string){
    this.NAMECLIENT = v;
  }

}
