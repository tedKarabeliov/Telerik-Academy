window.onload = function () {
    var input = [{
        mother: 'Maria Petrova',
        father: 'Georgi Petrov',
        children: ['Teodora Petrova', 'Peter Petrov']
    }, {
        mother: 'Petra Stamatova',
        father: 'Todor Stamatov',
        children: ['Maria Petrova']
    }];

    //Musaka input below
    //var input = [{
    //    mother: 'Ganka',
    //    father: 'Petur',
    //    children: ['Stefan', 'Rumqna']
    //}, {
    //    mother: 'Stanka',
    //    father: 'Rumen',
    //    children: ['Stamen', 'Petq', 'Stoqn']
    //}, {
    //    mother: 'Mariq',
    //    father: 'Ico',
    //    children: ['Ivo']
    //}, {
    //    mother: 'Pavlina',
    //    father: 'Genadi',
    //    children: ['Jivka']
    //}, {
    //    mother: 'Diana',
    //    father: 'Pesho',
    //    children: ['Iva']
    //}, {
    //    mother: 'Iva',
    //    father: 'Stefan',
    //    children: ['Joro']
    //}, {
    //    mother: 'Jivka',
    //    father: 'Joro',
    //    children: ['Stefani', 'Daniela']
    //}, {
    //    mother: 'Petq',
    //    father: 'Ivo',
    //    children: ['Doncho', 'Monika']
    //}, {
    //    mother: 'Rumqna',
    //    father: 'Stamen',
    //    children: ['Gancho', 'Mihaela']
    //}];

    var FamilyMember = function FamilyMember(name) {

        this.name = name;
        this.height = 0;
        this.position = 0;

        this.mother = null;
        this.father = null;
        this.partner = null;
        this.children = [];

        this.calculateHeight = function () {
            var currentChild = this;
            var motherHeight = 0;
            var fatherHeight = 0;

            while (currentChild.mother) {
                motherHeight++;
                currentChild = currentChild.mother;
            }
            currentChild = this;
            while (currentChild.father) {
                fatherHeight++;
                currentChild = currentChild.father;
            }


            this.height = Math.max(motherHeight, fatherHeight) + 1;
        }

        this.addChild = function (child) {
            this.children.push(child);
        }
    }

    var globalArray = [];
    var assignToArray = function (familyMember) {
        globalArray.push(familyMember);
    }
    Array.prototype.contains = function (familyMemberName) {
        for (var i = 0; i < this.length; i++) {
            if (this[i].name == familyMemberName) {
                return this[i];
            }
        }
        return null;
    }

    //ReadInput and assign all members into global array
    for (var i = 0; i < input.length; i++) {
        var currentInput = input[i];

        var familyMemberInArray = globalArray.contains(currentInput['mother']);
        if (familyMemberInArray) {
            var mother = familyMemberInArray;
        }
        else {
            var mother = new FamilyMember(currentInput['mother']);
            assignToArray(mother);
        }

        familyMemberInArray = globalArray.contains(currentInput['father'])
        if (familyMemberInArray) {
            var father = familyMemberInArray;
        }
        else {
            var father = new FamilyMember(currentInput['father']);
            assignToArray(father);
        }

        mother.partner = father;
        father.partner = mother;

        for (var k = 0; k < currentInput.children.length; k++) {

            familyMemberInArray = globalArray.contains(currentInput.children[k])
            if (familyMemberInArray) {
                var child = familyMemberInArray;
            }
            else {
                var child = new FamilyMember(currentInput.children[k]);
                assignToArray(child);
            }

            mother.addChild(child);
            father.addChild(child);
            child.mother = mother;
            child.father = father;
        }
    }

    //Calculate height for every member
    for (var i = 0; i < globalArray.length; i++) {
        var currentMember = globalArray[i];
        currentMember.calculateHeight();
    }

    //Adjust couples to be on the same height
    for (var i = 0; i < globalArray.length; i++) {
        var currentMember = globalArray[i];
        if (currentMember.partner) {
            if (currentMember.height < currentMember.partner.height) {
                currentMember.height = currentMember.partner.height;
            }
            else if (currentMember.height > currentMember.partner.height) {
                currentMember.partner.height = currentMember.height
            }
        }
    }

    //Adjust couples to be next to each other
    var getMaxHeightOfGlobalArray = function () {
        var maxHeight = 1;
        for (var i = 0; i < globalArray.length; i++) {
            var currentMember = globalArray[i];

            if (currentMember.height > maxHeight) {
                maxHeight = currentMember.height;
            }
        }
        return maxHeight;
    }

    var getMembersByHeight = function (height) {
        var membersByHeight = [];

        for (var i = 0; i < globalArray.length; i++) {
            var currentMember = globalArray[i];

            if (currentMember.height == height) {
                membersByHeight.push(currentMember);
            }
        }

        return membersByHeight;
    }

    var assignPositions = function (currentMembersHeightGroup) {

        for (var i = 0; i < currentMembersHeightGroup.length; i++) {
            var currentMember = currentMembersHeightGroup[i];
            if (currentMember.position == 0) {
                currentMember.position = i + 1;
            }

            if (currentMember.partner) {
                if (currentMember.partner.position == 0) {
                    currentMember.partner.position = currentMember.position + 1;
                    i++;
                }
            }

        }
    }

    var maxHeight = getMaxHeightOfGlobalArray();
    for (var height = 1; height <= maxHeight; height++) {
        var currentMembersHeightGroup = getMembersByHeight(height);
        assignPositions(currentMembersHeightGroup);
    }
    drawTree(globalArray);
}