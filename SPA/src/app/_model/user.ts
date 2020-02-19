export interface User {
    Id: number;
    UserName: string;
    PasswordHash: Blob;
    PasswordSalt: Blob;    
}
