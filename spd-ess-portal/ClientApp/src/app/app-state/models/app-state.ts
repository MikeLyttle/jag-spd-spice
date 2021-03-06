import { User } from '../../models/user.model';
import { ScreeningRequest } from '../../models/screening-request.model';
import { Ministry } from '../../models/ministry.model';
import { ScreeningReason } from '../../models/screening-reason.model';
import { FileUploadSet } from '../../models/file-upload-set.model';

export interface AppState {
    currentUserState: CurrentUserState;
    currentScreeningRequestState: CurrentScreeningRequestState;
    ministryScreeningTypesState: MinistryScreeningTypesState;
    screeningReasonsState: ScreeningReasonsState;
    fileUploadsState: FileUploadsState;
}

export interface CurrentUserState {
    currentUser: User | null;
}

export interface CurrentScreeningRequestState {
    currentScreeningRequest: ScreeningRequest | null;
}

export interface MinistryScreeningTypesState {
    ministryScreeningTypes: Ministry[] | null;
}

export interface ScreeningReasonsState {
    screeningReasons: ScreeningReason[] | null;
}

export interface FileUploadsState {
    fileUploads: FileUploadSet[];
}
