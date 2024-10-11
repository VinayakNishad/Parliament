class MemberOfParliament:
    def __init__(self, name, constituency, party):
        self.name = name
        self.constituency = constituency
        self.party = party
    
    def get_name(self):
        return self.name
    
    def set_name(self, name):
        self.name = name
    
    def get_constituency(self):
        return self.constituency
    
    def set_constituency(self, constituency):
        self.constituency = constituency
    
    def get_party(self):
        return self.party
    
    def set_party(self, party):
        self.party = party
