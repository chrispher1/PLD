import { Carrier } from './carrier';
import { Product } from './product';
import { Activity } from './activity';
import { Status } from './status';

export interface CommissionFinal {
    commId: number;
    carrId?: number;
    prodId?: number;
    polNum: string;
    yrNum?: number;
    tmCd: string;
    actCd: string;
    grsPremAmt?: number;
    commPremAmt: number;
    commRt?: number;
    commAmt?: number;
    statCd: string;
    statDt?: Date;
    crtDt: Date;
    crtById: string;
    modDt?: Date;
    modById: string;
    carr: Carrier;
    prod: Product;
    actCdNavigation: Activity;
    statCdNavigation: Status;
    isRevalidated: boolean;
}
