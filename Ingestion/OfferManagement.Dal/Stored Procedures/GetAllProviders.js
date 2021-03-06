/*
Copyright (c) Microsoft Corporation. All rights reserved. 
Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
*/
    
function getAllProviders() {
    var collection = getContext().getCollection();
    var query = 'SELECT r.id, r.name, r.provider_type, r.feed_type, r.enabled FROM root r where r.provider_type=1 or r.provider_type=0';
    var isAccepted = collection.queryDocuments(collection.getSelfLink(), query, callback);
    
    function callback(err, documents, responseOptions) {
        if (err) throw err;

        if (!documents || !documents.length)
            getContext().getResponse().setBody(null);
        else {
            getContext().getResponse().setBody(JSON.stringify(documents));
        }
    }

    if (!isAccepted)
        throw new Error("Query was not accepted by the server. Please try again");

}