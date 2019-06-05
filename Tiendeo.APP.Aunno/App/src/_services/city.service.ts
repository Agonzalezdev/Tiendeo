import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { City } from './../_models/city';
import { environment } from './../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CityService{
  private serviceUrl: string = environment.apiUrl + '/api/cities';

  constructor(private http: HttpClient) {}

  getAllCities(): Observable<City[]> {
    return this.http.get<City[]>(this.serviceUrl);
  }


}
