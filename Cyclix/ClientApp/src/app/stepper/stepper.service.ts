import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { CycleBrand } from 'src/models/CycleBrand';
import { CycleType } from 'src/models/CycleType';
import { RepairRequestModel } from 'src/models/RepairRequestMode';

@Injectable({
  providedIn: 'root',
})
export class StepperService {
  
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {}

  getBrands() : Observable<CycleBrand[]> {
    // return this.http.get<CycleBrand[]>(this.baseUrl + 'brand');
    return of(
      [
        { name: 'Trek' }, 
        { name: 'BMC' },
        { name: 'Scott' }
      ]);
  }
  getBikeType(): Observable<CycleType[]> {
    // return this.http.get<CycleType[]>(this.baseUrl + 'cycletype');
    return of(
      [
        { name: 'Rennvelo' }, 
        { name: 'Reisevelo' },
        { name: 'Elektro Velo' }
      ]);
  }

  saveRepairRequest(repairRequestModel: RepairRequestModel) : Observable<void> {
    return this.http.post<void>(this.baseUrl + 'repairrequest', repairRequestModel);
  }
}
