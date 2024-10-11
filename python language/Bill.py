class Bill:
    def __init__(self, title, bill_id, status):
        self.title = title
        self.status = status
        self.bill_id = bill_id
        self.votes = 0

    def get_title(self):
        return self.title

    def set_title(self, title):
        self.title = title

    def get_status(self):
        return self.status

    def set_status(self, status):
        self.status = status

    def get_votes(self):
        return self.votes

    def set_votes(self, votes):
        self.votes = votes

    def get_bill_id(self):
        return self.bill_id

    def set_bill_id(self, bill_id):
        self.bill_id = bill_id

    def vote(self):
        print(f"Voting on bill '{self.title}'")
        self.votes += 1
