import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { RedeSocial } from '@app/models/RedeSocial';
import { environment } from '@environments/environment';
import { Observable } from 'rxjs/internal/Observable';
import { take } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class RedeSocialService {
  baseURL = environment.apiURL + 'api/redesSociais';

  constructor(private http: HttpClient) {}

  public getRedesSociais(origem: string, id: number): Observable<RedeSocial[]> {
    let URL =
      id === 0
        ? `${this.baseURL}/${origem}`
        : `${this.baseURL}/${origem}/${id}`;

    return this.http.get<RedeSocial[]>(URL).pipe(take(1));
  }

  public saveRedesSociais(
    origem: string,
    id: number,
    redesSociais: RedeSocial[]
  ): Observable<RedeSocial[]> {
    let URL =
      id === 0
        ? `${this.baseURL}/${origem}`
        : `${this.baseURL}/${origem}/${id}`;

    return this.http.put<RedeSocial[]>(URL, redesSociais).pipe(take(1));
  }

  public deleteRedeSocial(
    origem: string,
    id: number,
    redeSocialId: number
  ): Observable<any> {
    let URL =
      id === 0
        ? `${this.baseURL}/${origem}/${redeSocialId}`
        : `${this.baseURL}/${origem}/${id}/${redeSocialId}`;

    return this.http.delete(URL).pipe(take(1));
  }
}
